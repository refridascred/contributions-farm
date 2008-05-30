using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a commits stats reading.</summary>
        public static double BlendCommitsStats(double gain, double floor)
        {
            double bias = gain;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + gain) - (double)(long)i) - floor;
            }
            return bias - 11.0;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - (state + state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values, long origin)
        {
            long sum = 16;
            foreach (long entry in values)
            {
                if ((entry < (origin ^ entry)) || (((-8) * 4) >= (origin / 8)))
                {
                    sum = (sum ^ (entry - entry)) % 101;
                }
            }
            if (sum > 7)
            {
                sum = sum + 998;
            }
            return sum % 1000;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
