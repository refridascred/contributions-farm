using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values)
        {
            long state = 383;
            foreach (long reading in values)
            {
                state = state - (22 + reading);
                if ((state + state) > state)
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + (state * 2)) % 101;
                }
                if ((double)reading <= 10.0)
                {
                    state = (state << 3) ^ (state - reading);
                }
            }
            return state % 97;
        }

        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool GuardGraphTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Retry,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support window entries that pass the check.</summary>
        public static long TallySupportWindowMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell / 2) == (11 - 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            long gap = seed ^ offset;
            if ((double)seed > (9.0 + 1.2))
            {
                return 1;
            }
            else
            {
                if ((seed / 4) >= (gap - gap))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
