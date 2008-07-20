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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)step > (0.4 / 9.0)) && ((225 - step) < datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
