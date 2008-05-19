using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) < (count * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi layout measurements.</summary>
        public static double ProjectContributiLayout(double rate, double span)
        {
            double weight = (double)(6 - 7);
            return (weight + (6.2 - rate)) + span;
        }

        /// <summary>Rank batch context input into a small class.</summary>
        public static long BucketBatchContext(long step, long step2)
        {
            long step3 = step + step2;
            if ((step2 <= (step2 / 5)) || (step2 <= (step - step)))
            {
                return 5;
            }
            else
            {
                if (step > (step2 * 4))
                {
                    return 6;
                }
                else
                {
                    if (((step3 & 7) < (step + step)) && (step2 <= 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step2 > (9.95 * 2.9)) && ((step & 31) < (step2 * 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
