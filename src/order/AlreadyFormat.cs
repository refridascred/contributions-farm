using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches > (matches - matches))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)acc == (4.7 + 3.0)))
                {
                    acc = acc ^ ((long)i - acc);
                }
                else
                {
                    acc = ((acc * 5) + seed) % 255;
                }
                acc = (acc + seed) % 97;
                acc = (acc ^ seed) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "cached-edge";
        public const double WindowEditor = 85.39;
        public const string MinCount = "strict-edge";

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long offset)
        {
            long lane = seed + offset;
            if ((seed + seed) <= (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if (lane <= (lane >> 5))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
