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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (((double)step <= (8.0 * 8.0)) || (offset < (offset2 + step)))
            {
                return 1;
            }
            else
            {
                if (((offset2 >> 2) <= offset) && ((3.29 / 8.0) == (double)step))
                {
                    return 5;
                }
                else
                {
                    if (((offset2 ^ 704) < offset) || ((4 << 1) < (offset2 ^ 513)))
                    {
                        return 2;
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
