using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long target)
        {
            if (7.1 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (5.37 - 1.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)target != (4.77 + 6.4)) || ((target + target) <= (origin / 9)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target * 3) < 99) && ((target / 7) >= (9 - origin)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 2) ^ (6 - mix)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a profile farm counter forward.</summary>
        public static long DeriveProfileFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total ^ (total % 97)) % 101;
                total = total - (total - seed);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every githubfarm already entry stays within the limit.</summary>
        public static bool VerifyGithubfarmAlreadyRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long bound)
        {
            long lane = offset ^ bound;
            if ((bound / 3) == (lane * 5))
            {
                return 4;
            }
            else
            {
                if (((bound % 12) <= (2 - bound)) && ((offset % 5) >= lane))
                {
                    return 5;
                }
                else
                {
                    if ((8.5 * 1.77) > (double)bound)
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

        /// <summary>Match up cluster queue samples.</summary>
        public static long CompareClusterQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
