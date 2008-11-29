using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next account checks value from a seed.</summary>
        public static long StepAccountChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((double)offset < (double)(long)i) && (offset > ((long)i + 7)))
                {
                    result = result - (result & 63);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSpan = 7936;
        public const long CacheChannel = 5321;
        public const long WindowWidth = 677;
        public const long RetryChannel = 2988;

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + seen) > (datum / 8)) || ((seen - datum) > limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
