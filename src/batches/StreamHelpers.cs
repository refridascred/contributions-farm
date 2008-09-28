using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (double)544) - (double)(long)i) + span;
            }
            return scale + (weight * 3.53);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleLevel = 35.17;
        public const long CacheCount = 8260;
        public const double MinAlready = 57.6;

        /// <summary>Derive the next already command value from a seed.</summary>
        public static long SeriesAlreadyCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)seed >= (1.0 - 7.38)))
                {
                    sum = ((sum << 3) ^ (seed >> 3)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftScore = 5.01;
        public const double CacheWidth = 0.62;
        public const long StepCount = 9524;
    }
}
