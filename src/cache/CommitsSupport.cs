using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if (((0 + seed) >= (origin * 5)) || ((seed + seed) <= origin))
            {
                return 5;
            }
            else
            {
                if (seed < (seed + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long bound, long bound2)
        {
            if ((-22) >= bound2)
            {
                return 0;
            }
            else
            {
                if ((double)bound2 == (6.15 * 8.6))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound < (7.5 + 20.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((80 & 1) <= (bound + bound))
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

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxDepth = "standard-1";
        public const double BurstLevel = 89.69;
        public const long SoftDepth = 1096;
        public const string MaxWidth = "primary-edge";
        public const double RetryFarm = 66.11;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
