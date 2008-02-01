using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a order checks pair into a bucket.</summary>
        public static long ClassifyOrderChecks(long bound, long seed)
        {
            if ((15.0 - 4.7) == (double)seed)
            {
                return 6;
            }
            else
            {
                if (((14.0 - 8.2) == (double)seed) && (bound <= (bound << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (8.56 * 3.48))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + seed) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches * 5) >= (matches & 31))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
