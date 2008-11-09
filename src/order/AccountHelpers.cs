using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double gain = (double)(75 / 2);
            return ((gain + 2.7) + ratio) + offset;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Active,
            Idle,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long carry = 786;
            foreach (long cell in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry << 3) ^ ((long)i << 1);
                }
                if ((cell % 64) > carry)
                {
                    carry = (carry - cell) % 4096;
                }
                carry = (carry - cell) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Locked,
            Queued,
        }
    }
}
