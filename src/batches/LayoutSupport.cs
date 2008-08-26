using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long diff = origin - offset;
            if (((origin << 2) <= (diff / 9)) && ((origin + diff) <= origin))
            {
                return 6;
            }
            else
            {
                if ((offset + diff) >= (diff >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) <= 939)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long bound, long step)
        {
            if (((91 + bound) == (step ^ step)) && ((334 + bound) > (step >> 1)))
            {
                return 8;
            }
            else
            {
                if ((bound << 3) != (step % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 3) >= (bound + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.46 * 7.1) == (double)bound)
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

        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long TallyRouteClusterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + count) > (count / 5))
                {
                    count = ((count + 3) + reading) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long acc = 65;
            foreach (long reading in levels)
            {
                if (((step / 2) <= (acc % 3)) && (4.0 > (13.0 / 6.0)))
                {
                    acc = acc + (reading + step);
                }
                else
                {
                    acc = acc ^ step;
                }
            }
            if (acc < 86)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 2) <= (entry ^ count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
