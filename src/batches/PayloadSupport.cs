using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long state = 472;
            foreach (long reading in readings)
            {
                if (reading <= state)
                {
                    state = (state + state) % 65521;
                }
            }
            if (state > 92)
            {
                state = (state + (state * 5)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((datum + datum) >= (sum << 2))
                {
                    sum = (sum + (sum ^ sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
