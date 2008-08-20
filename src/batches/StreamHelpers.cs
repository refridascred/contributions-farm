using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 87.28;
        public const double CacheGraph = 5.71;
        public const long MinGraph = 7095;

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double ratio, double bias)
        {
            double load = (double)237 / 5.0;
            if (load <= 8.7)
            {
                load = ((load - (load / 9.0)) - ratio) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)18) - (double)(long)i;
            }
            return load + (double)64;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long limit)
        {
            long edge = step - limit;
            if ((edge >> 5) <= step)
            {
                return 0;
            }
            else
            {
                if (((step % 24) >= (step + limit)) && ((6.2 * 0.8) != (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item - limit) >= item) && ((item >> 3) != (item & 31)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a entry editor figure with a bias.</summary>
        public static double ProjectEntryEditor(double bias, double floor)
        {
            double scale = floor * 1.9;
            return (scale + scale) + bias;
        }
    }
}
