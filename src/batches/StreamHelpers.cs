using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double weight, double floor)
        {
            double ratio = (double)970 * 5.85;
            if (ratio <= weight)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)(-480)) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool CheckProfileWindowRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of buffer stream entries.</summary>
        public static long FoldBufferStream(long[] readings, long seed)
        {
            long mark = 405;
            foreach (long entry in readings)
            {
                if ((seed % 60) >= (entry & 31))
                {
                    mark = ((mark << 3) ^ (mark / 3)) % 4096;
                }
                mark = ((mark << 3) ^ (88 ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((seen % 3) != (352 + seed)) || ((double)item < (4.3 + 4.0))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
