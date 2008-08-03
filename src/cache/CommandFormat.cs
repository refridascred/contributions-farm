using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long target)
        {
            if (7.1 < (double)target)
            {
                return 3;
            }
            else
            {
                if ((floor - floor) < (target & 31))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor) == (target ^ 255)) && ((floor & 1) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((96 / 3) > floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
