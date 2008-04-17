using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long score = 26;
            foreach (long datum in values)
            {
                if ((datum & 31) == (floor + score))
                {
                    score = (score + (datum & 1)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ 0) - (long)i2;
                }
                state = (state + ((long)i ^ origin)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values)
        {
            long anchor = 964;
            foreach (long item in values)
            {
                if (((anchor + 0) > (item - item)) || ((double)anchor == (double)item))
                {
                    anchor = anchor + (anchor << 2);
                }
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 97;
        }
    }
}
