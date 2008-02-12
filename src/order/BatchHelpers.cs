using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] series, long origin)
        {
            long state = 472;
            foreach (long reading in series)
            {
                state = ((state * 2) + reading) % 97;
                state = (state * 4) + (state << 2);
            }
            if (state < 34)
            {
                state = ((state * 2) + (origin ^ 106)) % 255;
            }
            return state;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count > (value * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
