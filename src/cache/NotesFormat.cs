using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the buffer channel entries that pass the check.</summary>
        public static long TallyBufferChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((699 / 5) >= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long bound)
        {
            if ((seed ^ bound) >= bound)
            {
                return 8;
            }
            else
            {
                if ((7.7 - 17.0) > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((82 + 2) >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (96 << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (offset / 5.0))
            {
                bias = bias - (double)3;
            }
            return bias - rate;
        }
    }
}
