using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            if (!((offset - floor) <= floor))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) != (offset / 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (9.0 + 5.0))
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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels, long limit)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ ((-3) + 65)) % 65521;
                if (!((limit ^ reading) >= (reading + limit)))
                {
                    state = (state ^ (limit >> 1)) % 97;
                }
                if (state < (32 / 9))
                {
                    state = (state - (reading / 7)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Validate order route readings against a bound.</summary>
        public static bool ValidateOrderRouteBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < rate)
            {
                ratio = (ratio + ratio) - offset;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio + ratio;
        }
    }
}
