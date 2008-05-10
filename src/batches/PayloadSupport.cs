using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items, long seed)
        {
            long acc = 84;
            foreach (long cell in items)
            {
                acc = ((acc << 3) ^ (cell + acc)) + seed;
            }
            if (acc < (-14))
            {
                acc = acc ^ (6 ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            long step = offset + offset2;
            if (offset2 >= (step * 3))
            {
                return 8;
            }
            else
            {
                if (((15 - offset2) != (offset % 60)) || ((offset2 + step) > (130 >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (offset2 > (step - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (9.0 > (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 772;
            foreach (long sample in series)
            {
                if (sample > (sample ^ mark))
                {
                    mark = mark - (sample * 3);
                }
            }
            if (mark < 64)
            {
                mark = (mark << 3) ^ (0 + mark);
            }
            return mark % 1000;
        }
    }
}
