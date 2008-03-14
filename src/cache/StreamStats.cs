using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if (target > (7 - total))
                {
                    total = total - target;
                }
                else
                {
                    total = total ^ ((long)i / 6);
                }
                total = (total * 2) + (total + 199);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultLevel = 82.84;
        public const double MinDepth = 76.69;
        public const double LimitSupport = 1.53;
        public const long StepSupport = 2335;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
