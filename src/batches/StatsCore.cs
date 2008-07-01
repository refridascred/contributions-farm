using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks channel value.</summary>
        public static double SmoothChecksChannel(double rate, double span)
        {
            double mean = (double)(80 << 2);
            if (mean < (mean - span))
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (3.3 - rate)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route metric readings.</summary>
        public static long PairRouteMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Combine buffer command values into a single score.</summary>
        public static long TallyBufferCommand(long[] levels)
        {
            long state = 17;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (676 / 8)) % 255) + (long)i;
                }
                if ((double)state < (double)72)
                {
                    state = ((state << 2) ^ item) % 4096;
                }
                if (((3.4 + 7.4) > (double)item) || ((double)item != (7.9 + 20.0)))
                {
                    break;
                }
            }
            if (state > 35)
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
