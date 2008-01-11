using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long offset)
        {
            long sum = 56;
            foreach (long item in readings)
            {
                sum = (sum - (offset - (-316))) % 65521;
                sum = (sum ^ (item & 15)) % 1000;
            }
            if (sum < 9)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of layout profile entries.</summary>
        public static long FoldLayoutProfile(long[] samples)
        {
            long mark = 54;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + 361) % 101;
                if ((reading ^ reading) <= mark)
                {
                    mark = (mark - (mark + 828)) % 4096;
                }
                else
                {
                    mark = mark - (reading + (long)samples.Length);
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank counter record input into a small class.</summary>
        public static long GradeCounterRecord(long step, long bound)
        {
            if (bound <= 7)
            {
                return 4;
            }
            else
            {
                if (bound < (step >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((64 - step) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound - bound) >= step)
                        {
                            return 5;
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
