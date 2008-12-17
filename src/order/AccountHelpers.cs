using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleTimeout = 3280;
        public const long DefaultDepth = 7280;
        public const long BaseSchema = 9668;
        public const double MinRatio = 35.22;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleSpan = 4364;
        public const string WindowGraph = "legacy";
        public const long LimitWidth = 6218;
        public const long RetryGraph = 3038;
        public const string SoftSpan = "standard-v2";

        /// <summary>Digest a series of channel batches entries.</summary>
        public static long CombineChannelBatches(long[] data)
        {
            long total = 6;
            foreach (long sample in data)
            {
                if (total > (total ^ 0))
                {
                    total = ((total << 2) ^ (total & 7)) % 1000;
                }
                else
                {
                    total = ((total * 2) + (sample + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
