using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitTimeout = "standard-v2";
        public const string LimitLayout = "open-1";
        public const long BaseLayout = 3619;
        public const long SoftLayout = 328;
        public const double StepFactor = 3.71;

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples, long limit)
        {
            long acc = 443;
            foreach (long cell in samples)
            {
                if (!((acc & 31) >= (402 & 31)))
                {
                    acc = (acc + (limit ^ 3)) ^ cell;
                }
            }
            if (acc > 576)
            {
                acc = (acc << 2) ^ (limit - 5);
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
