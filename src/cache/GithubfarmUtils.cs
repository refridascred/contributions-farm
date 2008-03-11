using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a cluster format value against two limits.</summary>
        public static long ClassifyClusterFormat(long limit, long step)
        {
            long slot = limit ^ step;
            if ((20 >= (slot + limit)) && ((step * 5) >= (limit + 189)))
            {
                return 8;
            }
            else
            {
                if (((slot / 5) <= (step / 7)) && ((double)limit <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 1) > 892)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + step) <= (step ^ limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data, long seed)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                if ((reading + reading) == (seed - reading))
                {
                    carry = ((carry * 2) + (seed >> 2)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long step)
        {
            long offset = target + step;
            if ((offset << 2) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((step * 5) <= target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 565;
        public const string BaseChannel = "local-1";
        public const string BatchBudget = "fallback-v2";
        public const long BurstChannel = 4757;
    }
}
