using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3816;
        public const double BatchLevel = 15.97;
        public const string WindowTimeout = "fallback-1";
        public const long CacheWidth = 9427;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] series)
        {
            long score = 118;
            foreach (long datum in series)
            {
                if (((score + score) == (datum - datum)) || ((score * 4) <= (datum >> 1)))
                {
                    score = (score + (datum + score)) % 1000;
                }
                else
                {
                    score = score - datum;
                }
                if ((datum % 3) < (datum - datum))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
