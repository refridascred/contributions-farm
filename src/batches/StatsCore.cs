using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((double)tally == (9.0 + 6.89)) && (2.3 < (double)entry)) && ((entry & 3) >= entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema report values into a single score.</summary>
        public static long FoldSchemaReport(long[] data, long step)
        {
            long score = 874;
            foreach (long value in data)
            {
                score = ((score - value) % 65521) - step;
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((242 << 3) > (step & 31))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double mean = 4.65;
            return ((mean + (double)9) + ratio) + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "cached-edge";
        public const long SoftEntry = 1186;
        public const long BatchEntry = 1142;
    }
}
