using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long floor, long target)
        {
            if ((2 - target) > (574 / 5))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) < (floor ^ target))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) != (82 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Ready,
            Active,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a stats batches sample.</summary>
        public static long SeekStatsBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long origin2)
        {
            if (origin < origin2)
            {
                return 3;
            }
            else
            {
                if ((6.25 - 0.1) == (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (!((origin << 2) != (origin ^ origin)))
                    {
                        return 6;
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
