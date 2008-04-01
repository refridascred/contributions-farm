using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long origin)
        {
            long prev = bound - origin;
            if ((prev + prev) > (origin << 1))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (double)827)
                {
                    return 0;
                }
                else
                {
                    if (((origin << 1) >= (bound >> 3)) || ((bound * 4) < (bound + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev <= (bound + prev)) && ((origin - bound) < (origin + 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long offset)
        {
            if ((target >> 5) >= (offset - offset))
            {
                return 1;
            }
            else
            {
                if (!((-72) < (offset >> 2)))
                {
                    return 5;
                }
                else
                {
                    if (((target & 15) < (-732)) && ((double)offset > (2.85 * 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
