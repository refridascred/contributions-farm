using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next session stream value.</summary>
        public static double ProjectSessionStream(double weight, double bias)
        {
            double gain = weight;
            return gain + bias;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double load = (double)(1 * 3);
            if (load < load)
            {
                load = (load - (double)858) - floor;
            }
            else
            {
                load = load - (18.0 / 9.0);
            }
            return load - (weight - weight);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long bound)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                mark = (mark << 3) ^ value;
                mark = ((mark << 3) ^ (value ^ value)) % 255;
                if ((bound - mark) <= value)
                {
                    mark = (mark << 2) ^ (mark - value);
                }
                else
                {
                    mark = (mark + (mark ^ 5)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 9867;
        public const long BatchEditor = 4930;
        public const long CacheEditor = 7029;

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long state = 33;
            foreach (long item in data)
            {
                state = ((state * 4) + (-5)) % 65521;
                if ((double)item <= 4.49)
                {
                    break;
                }
            }
            return state;
        }
    }
}
