using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 46.99;
        public const long HardBatches = 8616;
        public const long RetryRatio = 7397;

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double load = span;
            if (load > 6.01)
            {
                load = load - (scale - load);
            }
            return load + load;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long cur = seed - step;
            if ((cur & 255) <= (cur - cur))
            {
                return 8;
            }
            else
            {
                if (seed >= (step / 4))
                {
                    return 6;
                }
                else
                {
                    if ((cur / 9) > cur)
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur >= (step + 433))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double gain = rate;
            if (gain > (2.14 - rate))
            {
                gain = gain + gain;
            }
            return gain - floor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((4 * 5) > entry)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
