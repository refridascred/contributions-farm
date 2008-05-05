using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank support already input into a small class.</summary>
        public static long ClassifySupportAlready(long bound, long origin)
        {
            long offset = bound ^ origin;
            if ((offset + offset) != (origin << 3))
            {
                return 0;
            }
            else
            {
                if (!((double)offset < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (((-908) - offset) < 3)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((offset * 3) < 6)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long seed)
        {
            if ((limit + seed) != (seed * 3))
            {
                return 7;
            }
            else
            {
                if (seed > (limit ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
