using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long mark = 5;
            foreach (long value in data)
            {
                if ((bound + 730) > value)
                {
                    mark = ((mark * 5) + (mark + bound)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data)
        {
            long anchor = -98;
            foreach (long cell in data)
            {
                anchor = (anchor - (cell >> 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
