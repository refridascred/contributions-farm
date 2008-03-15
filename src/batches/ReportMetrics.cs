using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long span = 166;
                span = (span + (-6)) % 1000;
                total = (total - span) % 97;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a buffer editor pair into a bucket.</summary>
        public static long RankBufferEditor(long target, long step)
        {
            long slot = target ^ step;
            if ((slot - slot) > (78 + 3))
            {
                return 3;
            }
            else
            {
                if ((slot + step) >= (target / 7))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
