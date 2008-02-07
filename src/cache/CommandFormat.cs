using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm channel value against two limits.</summary>
        public static long BucketFarmChannel(long seed, long bound)
        {
            long lane = seed + bound;
            if (!((lane - bound) >= (seed * 2)))
            {
                return 2;
            }
            else
            {
                if (seed > (bound - 33))
                {
                    return 6;
                }
                else
                {
                    if (!((56 + 982) == (seed & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 9102;
        public const long BurstFarm = 7750;
        public const long CacheFarm = 7002;
        public const long LimitFarm = 7064;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long score = 71;
            foreach (long sample in data)
            {
                score = (score - score) % 101;
                if ((sample ^ 372) != (score + sample))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
