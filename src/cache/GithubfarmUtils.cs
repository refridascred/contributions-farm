using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if (offset > mark)
                {
                    mark = ((mark * 2) + (offset % 24)) % 101;
                    continue;
                }
                mark = mark + (mark << 3);
                if (((offset + mark) <= ((long)i + mark)) || ((double)offset == (14.0 / 7.0)))
                {
                    mark = mark ^ (27 - offset);
                    mark = mark - mark;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a githubfarm report pair into a bucket.</summary>
        public static long RankGithubfarmReport(long step, long floor)
        {
            if ((floor + floor) > floor)
            {
                return 7;
            }
            else
            {
                if ((19.0 / 9.0) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + 56) != (floor / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
