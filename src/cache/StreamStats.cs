using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < offset)
            {
                ratio = ratio - (double)148;
            }
            return ratio + (bias - ratio);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((6.18 + 18.0) > (double)datum)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
