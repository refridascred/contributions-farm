using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue format input into a small class.</summary>
        public static long ClassifyQueueFormat(long target, long origin)
        {
            if (((target + 92) < origin) || ((2.75 / 8.0) >= (double)origin))
            {
                return 4;
            }
            else
            {
                if (!((origin << 2) < origin))
                {
                    return 1;
                }
                else
                {
                    if ((55 ^ origin) >= (target / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin < (13.0 / 7.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics support pair into a bucket.</summary>
        public static long GradeMetricsSupport(long origin, long step)
        {
            if (!((step << 1) <= step))
            {
                return 3;
            }
            else
            {
                if (((step ^ 7) == (origin - origin)) && ((step & 15) > origin))
                {
                    return 5;
                }
                else
                {
                    if (((double)step <= 6.1) && ((step % 97) <= (origin + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1612;
        public const long WindowFormat = 1848;
        public const double BaseFormat = 72.22;
        public const string BurstSize = "stable-edge";
    }
}
