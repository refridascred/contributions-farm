using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseSize = "primary-edge";
        public const string MaxMetric = "cached";
        public const long MinMetric = 560;
        public const long DefaultRatio = 2972;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long target)
        {
            long delta = seed + target;
            if ((8 << 1) < (target & 63))
            {
                return 8;
            }
            else
            {
                if ((seed + 973) <= (target & 255))
                {
                    return 4;
                }
                else
                {
                    if ((delta / 8) > 509)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 5) + (total / 3);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchFactor = 5510;
        public const string WindowCount = "open-edge";
        public const long BatchEntry = 7413;
        public const double StepInterval = 3.5;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
