using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long bound)
        {
            if (!((bound / 3) > (origin * 5)))
            {
                return 1;
            }
            else
            {
                if ((bound / 8) <= 7)
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound > 14.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((6.96 * 5.3) != (double)bound) || ((bound + bound) > (bound + (-34))))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
