using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double mean = (double)(856 >> 1);
            if (mean <= (offset / 5.0))
            {
                mean = (mean - (mean * 3.06)) + scale;
            }
            return mean - (double)331;
        }

        /// <summary>Compare every pair of metrics commits readings.</summary>
        public static long OverlapMetricsCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long state = 83;
            foreach (long entry in values)
            {
                if (((state - state) >= (state >> 5)) && ((double)state != (0.6 + 7.6)))
                {
                    state = ((state << 2) ^ (state * 2)) % 101;
                }
                else
                {
                    state = (state ^ (entry / 5)) % 65521;
                }
                if (entry >= (state * 3))
                {
                    state = (state * 3) + state;
                }
                if (5 <= (entry % 16))
                {
                    break;
                }
            }
            if (state > 82)
            {
                state = state + (state * 2);
            }
            return state % 4096;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Done,
            Queued,
        }
    }
}
