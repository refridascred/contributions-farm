using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a support context pair into a bucket.</summary>
        public static long BucketSupportContext(long offset, long origin)
        {
            if (((0.9 + 4.0) > 4.0) || ((double)origin < (double)44))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset < origin) || (offset > origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9564;
        public const double BaseTools = 67.24;
        public const string DefaultInterval = "legacy";
        public const long WindowSize = 7607;
        public const string IdleFactor = "alpha";

        /// <summary>Measure how many counter graph samples are out of range.</summary>
        public static long MeasureCounterGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 5) > (hits + hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
