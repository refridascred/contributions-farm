using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long MeasureSessionEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((8.3 * 16.0) >= (double)item) || ((seen << 1) != (seen % 64)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a payload cache counter forward.</summary>
        public static long StepPayloadCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = acc ^ 9;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
