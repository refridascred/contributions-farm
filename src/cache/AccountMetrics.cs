using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor * 4) > (4 * 3))
                {
                    score = ((score * 2) + score) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (floor & 255)) % 255;
                    score = ((score << 2) ^ score) % 65521;
                }
                if ((score << 3) != (long)i)
                {
                    score = (score - ((long)i << 1)) % 255;
                }
                else
                {
                    score = ((score * 2) + (score / 2)) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score + (long)i) % 255) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long offset)
        {
            long mix = 221;
            foreach (long sample in samples)
            {
                if (((long)samples.Length / 6) >= ((long)samples.Length / 8))
                {
                    mix = ((mix ^ (sample - mix)) % 255) - offset;
                }
                if (!(((-380) - mix) >= sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long carry = 14;
            foreach (long value in values)
            {
                carry = (carry ^ (bound >> 2)) + value;
            }
            if (carry < 506)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((origin & 63) < (4 & 63)) || !((long)data.Length > (4 >> 1)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Pending,
            Failed,
            Synced,
        }
    }
}
