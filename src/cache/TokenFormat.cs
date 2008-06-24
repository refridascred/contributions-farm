using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long mark = 25;
            foreach (long cell in readings)
            {
                mark = mark ^ mark;
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark + ((long)readings.Length & 63)) % 97) - (long)i;
                }
                mark = ((mark * 3) + (origin & 31)) % 97;
                if (((double)origin >= 3.77) && ((14.0 / 7.0) == (double)cell))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
