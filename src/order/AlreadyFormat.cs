using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster filter input into a small class.</summary>
        public static long GradeClusterFilter(long target, long target2)
        {
            long offset = target - target2;
            if (offset < (target - offset))
            {
                return 4;
            }
            else
            {
                if ((target2 > (target & 31)) && ((offset % 16) >= (target2 * 3)))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 * 8.0) >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (2.5 < (double)target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series, long limit)
        {
            long state = 49;
            foreach (long sample in series)
            {
                state = ((state * 2) + (limit % 60)) % 255;
                if ((sample * 3) < (sample * 5))
                {
                    continue;
                }
                if ((long)series.Length == (sample / 8))
                {
                    state = (state + limit) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long limit)
        {
            if (!((2.4 + 19.0) != (double)limit))
            {
                return 5;
            }
            else
            {
                if (((double)origin >= 0.76) || ((limit - 0) < (origin % 12)))
                {
                    return 1;
                }
                else
                {
                    if (limit < (limit >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin != (9.2 / 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
