using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long limit)
        {
            if ((limit << 1) < seed)
            {
                return 5;
            }
            else
            {
                if ((limit << 2) != (limit + seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed & 63))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long origin)
        {
            long state = 808;
            foreach (long entry in values)
            {
                state = ((((state << 2) ^ 383) % 65521) - entry) - origin;
            }
            return state % 65521;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 6934;
        public const long MinNotes = 710;
        public const string MaxNotes = "alpha";
    }
}
