using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a record context reading.</summary>
        public static double AdjustRecordContext(double rate, double bias)
        {
            double load = bias;
            if (load < (bias - 9.65))
            {
                load = (load + (load + 16.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - 3.5) + (double)(long)i;
            }
            return load - (double)5;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long offset)
        {
            if (((offset / 3) <= step) && ((2.0 / 3.0) < (double)offset))
            {
                return 6;
            }
            else
            {
                if (!(offset <= (offset + 59)))
                {
                    return 5;
                }
                else
                {
                    if (((step / 2) <= (step + step)) || ((step + step) <= (offset >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset / 3) != (offset % 8)) || ((9.6 / 5.0) <= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
