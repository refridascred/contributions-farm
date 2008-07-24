using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Combine order support values into a single score.</summary>
        public static long ScoreOrderSupport(long[] readings, long bound)
        {
            long carry = 166;
            foreach (long datum in readings)
            {
                if ((9 ^ bound) == (2 & 3))
                {
                    carry = (carry << 3) ^ (datum - datum);
                }
            }
            return carry % 97;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
