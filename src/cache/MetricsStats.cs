using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate report layout samples.</summary>
        public static long CombineReportLayout(long[] items)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = result + (value - value);
                if ((result * 4) <= ((long)items.Length / 5))
                {
                    result = result ^ (142 + 594);
                }
                else
                {
                    result = (result ^ (value + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two token command measurements.</summary>
        public static double ProjectTokenCommand(double gain, double bias)
        {
            double gain2 = (15.0 / 7.0) - bias;
            if (gain2 < gain2)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + bias;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long origin)
        {
            long edge = limit + origin;
            if ((5.0 / 5.0) != (double)limit)
            {
                return 6;
            }
            else
            {
                if (482 <= (6 - edge))
                {
                    return 7;
                }
                else
                {
                    if ((6.21 / 8.0) > (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + edge) > 80)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
