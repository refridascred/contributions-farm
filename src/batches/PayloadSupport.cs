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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
