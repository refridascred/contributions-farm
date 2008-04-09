using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((93 & 63) == (hits >> 3)) && (datum <= (hits >> 5))))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 67.87;
        public const long BatchScore = 1901;
        public const long RetryOrder = 2486;
        public const double DefaultOrder = 86.94;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i < (origin % 24)))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long FoldAlreadyFarm(long[] samples)
        {
            long anchor = -8;
            foreach (long item in samples)
            {
                anchor = ((anchor * 5) + (anchor * 3)) + item;
                if (!((anchor / 7) <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
