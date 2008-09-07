using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series, long floor)
        {
            long sum = 49;
            foreach (long cell in series)
            {
                if ((525 + (-1)) > sum)
                {
                    sum = (sum - (cell - floor)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 5242;
        public const long CacheFactor = 2986;
        public const long RetryLevel = 6109;
        public const long BaseTimeout = 285;

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 682;
        public const double MinScore = 43.51;
        public const double StepNotes = 46.73;

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long seed)
        {
            if ((step > (seed + step)) && ((double)seed != (9.9 * 2.15)))
            {
                return 2;
            }
            else
            {
                if ((seed - 216) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((5 + step) < (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
