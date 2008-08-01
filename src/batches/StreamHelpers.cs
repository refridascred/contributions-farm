using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long bound, long target)
        {
            long span = bound + target;
            if (((14.0 + 6.1) < (double)bound) || ((target / 9) == (bound - bound)))
            {
                return 5;
            }
            else
            {
                if (!((span % 24) > (target / 7)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long seed, long limit)
        {
            if (!(((-37) ^ limit) > (seed >> 3)))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) <= (limit >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((5.92 + 7.58) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed > (551 + limit)) || ((seed - seed) >= (limit ^ seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardWidth = 1846;
        public const double HardRoute = 70.11;
        public const double HardCount = 12.7;
        public const double MaxRoute = 95.59;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 2);
                if (offset <= (offset % 100))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
