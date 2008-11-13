using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool VerifyBatchCommandRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long origin)
        {
            long span = floor - origin;
            if ((span >> 4) != (span % 7))
            {
                return 4;
            }
            else
            {
                if ((span * 4) == (span << 2))
                {
                    return 8;
                }
                else
                {
                    if ((5.6 / 2.0) == (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((span & 127) == (origin + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits > (7.5 + 1.45))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
