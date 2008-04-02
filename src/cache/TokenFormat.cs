using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of editor batch readings.</summary>
        public static long CompareEditorBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long offset)
        {
            long anchor = 43;
            foreach (long datum in readings)
            {
                if ((9.7 - 1.67) != (double)offset)
                {
                    anchor = (anchor ^ (offset >> 4)) - datum;
                }
                if ((anchor + 759) > anchor)
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor * 2) + (offset / 9);
            }
            return anchor;
        }

        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long GradeStreamChannel(long seed, long step)
        {
            long next = seed ^ step;
            if ((seed & 15) > seed)
            {
                return 2;
            }
            else
            {
                if (((2.83 / 5.0) <= (double)seed) && ((double)step > (1.5 - 17.0)))
                {
                    return 8;
                }
                else
                {
                    if (((-497) < (next % 100)) || (step >= (84 / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (8 <= (next << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
