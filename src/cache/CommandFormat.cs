using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long offset)
        {
            long step = bound + offset;
            if (!((double)step > (0.4 / 2.0)))
            {
                return 4;
            }
            else
            {
                if (bound < (479 % 8))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) == (offset ^ offset)) && (step > (offset >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >> 2) == (bound % 12))
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
