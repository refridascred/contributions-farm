using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long state = 239;
            foreach (long sample in data)
            {
                state = state ^ sample;
                for (int i = 0; i < 8; i++)
                {
                    state = ((state - 65) % 4096) - (long)i;
                }
                if ((329 / 8) > sample)
                {
                    state = ((state * 2) + 828) % 97;
                }
                else
                {
                    state = state ^ sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every queue support entry stays within the limit.</summary>
        public static bool ValidateQueueSupportRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long offset)
        {
            if ((offset << 1) < origin)
            {
                return 8;
            }
            else
            {
                if (((offset >> 1) <= origin) && ((double)offset <= (14.0 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    if (((offset << 3) < origin) && ((offset + origin) <= 9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - (-677)) == (offset % 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count batch already pairs that satisfy a relation.</summary>
        public static long PairBatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
