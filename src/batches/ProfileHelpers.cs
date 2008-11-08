using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long acc = 393;
            foreach (long item in items)
            {
                if (item <= acc)
                {
                    acc = (acc ^ (item >> 3)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long origin2)
        {
            long bound = origin + origin2;
            if (origin >= (origin2 + bound))
            {
                return 4;
            }
            else
            {
                if ((((-168) + bound) <= (origin * 4)) || (origin > origin2))
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 5) < (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > 37)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.02 - 4.0) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (offset & 3);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long mark = 73;
            foreach (long datum in data)
            {
                mark = ((mark + (2 / 5)) % 4096) ^ datum;
            }
            return mark;
        }
    }
}
