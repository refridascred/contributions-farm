using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long seed)
        {
            long bound = step ^ seed;
            if ((double)step == (double)seed)
            {
                return 6;
            }
            else
            {
                if (!((seed + seed) != (step ^ bound)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((5.3 * 1.2) > (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
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
