using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (983 < (cell - hits))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long RollTokenGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                bool ready = (double)60 <= (double)floor;
                if (!(ready && (floor >= (mix >> 5))))
                {
                    ready = floor > (mix / 3);
                    ready = (3 * 4) < ((long)i - mix);
                }
                if (!((0 * 4) <= floor))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long limit)
        {
            if ((double)target >= (13.0 / 9.0))
            {
                return 4;
            }
            else
            {
                if ((limit + target) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((target & 31) < (422 >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long floor)
        {
            long delta = origin + floor;
            if ((delta ^ delta) < (3 / 9))
            {
                return 4;
            }
            else
            {
                if (((origin + floor) > (origin << 2)) && ((floor + delta) > (origin << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)512 <= (double)delta)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
