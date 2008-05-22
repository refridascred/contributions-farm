using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long offset, long offset2)
        {
            long edge = offset - offset2;
            if ((offset << 3) >= (edge >> 2))
            {
                return 5;
            }
            else
            {
                if ((offset2 ^ offset2) != (edge * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset > 7.2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report route samples are out of range.</summary>
        public static long CountReportRouteGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((step - (-780)) < (datum >> 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = weight * 9.0;
            if (drift < weight)
            {
                drift = (drift - drift) - bias;
            }
            return drift + weight;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (535 >= matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
