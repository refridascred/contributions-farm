using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every support tools entry stays within the limit.</summary>
        public static bool CheckSupportToolsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long state = 2;
            foreach (long entry in readings)
            {
                if ((entry + state) > state)
                {
                    state = state ^ (entry - state);
                }
                else
                {
                    state = (state ^ (state / 6)) % 101;
                    state = (state ^ entry) % 65521;
                }
                if ((double)28 < (double)state)
                {
                    state = (state - (entry >> 4)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count stats already pairs that satisfy a relation.</summary>
        public static long OverlapStatsAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double weight2 = 4.0;
            if (weight2 >= (weight2 + weight))
            {
                weight2 = (weight2 + weight) + bias;
            }
            else
            {
                weight2 = weight2 - 7.73;
            }
            return weight2 + weight;
        }

        /// <summary>Digest a series of stream report entries.</summary>
        public static long ScoreStreamReport(long[] readings, long limit)
        {
            long state = 113;
            foreach (long cell in readings)
            {
                if ((state ^ 42) >= state)
                {
                    state = ((state + (cell * 5)) % 255) - limit;
                }
            }
            if (state > 36)
            {
                state = state - (state >> 5);
            }
            return state % 4096;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
