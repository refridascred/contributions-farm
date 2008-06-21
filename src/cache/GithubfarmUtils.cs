using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long origin)
        {
            long offset = step ^ origin;
            if (!((5 + step) != (step / 3)))
            {
                return 2;
            }
            else
            {
                if (10.0 < (double)step)
                {
                    return 5;
                }
                else
                {
                    if (!((offset + offset) <= (step % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step ^ offset) <= (origin + offset))
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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Pending,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
