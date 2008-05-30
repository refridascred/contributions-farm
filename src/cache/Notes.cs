using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first queue counter entry that matches the target.</summary>
        public static long FindQueueCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix ^ (mix + (long)i)) % 255;
                mix = ((mix << 2) ^ (long)i) % 4096;
                if (((long)i + (long)i) != (mix >> 4))
                {
                    mix = (mix ^ (49 / 5)) % 101;
                    mix = (mix * 3) + (offset / 9);
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (diff > floor)
            {
                return 8;
            }
            else
            {
                if (((diff << 3) != (floor + diff)) || ((8 ^ floor) >= floor))
                {
                    return 0;
                }
                else
                {
                    if ((17 / 4) == (limit + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long RankCommitsProfile(long floor, long origin)
        {
            if ((floor + floor) >= (floor + origin))
            {
                return 0;
            }
            else
            {
                if ((double)floor < 8.0)
                {
                    return 5;
                }
                else
                {
                    if (origin <= (floor & 1))
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
    }
}
