using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double ratio = (double)(6 - 3);
            if (ratio < (double)746)
            {
                ratio = (ratio + (16.0 - offset)) - gain;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)79) + (double)(long)i;
            }
            return ratio + (double)5;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry token entries.</summary>
        public static long FoldEntryToken(long[] data, long limit)
        {
            long carry = 91;
            foreach (long item in data)
            {
                if (!((carry - limit) == (item + limit)))
                {
                    carry = carry - (512 + 5);
                    carry = carry - (45 % 60);
                }
                if (((long)data.Length << 1) <= (carry * 2))
                {
                    carry = carry + 938;
                }
                if (((395 % 10) > (limit ^ 0)) || ((limit + 32) <= 840))
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
