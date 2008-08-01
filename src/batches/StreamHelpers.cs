using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long bound, long target)
        {
            long span = bound + target;
            if (((14.0 + 6.1) < (double)bound) || ((target / 9) == (bound - bound)))
            {
                return 5;
            }
            else
            {
                if (!((span % 24) > (target / 7)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank layout format input into a small class.</summary>
        public static long GradeLayoutFormat(long origin, long floor)
        {
            long diff = origin + floor;
            if ((9.05 > (double)origin) && ((73 >> 2) != (5 - origin)))
            {
                return 5;
            }
            else
            {
                if ((84 + floor) < diff)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long seed, long limit)
        {
            if (!(((-37) ^ limit) > (seed >> 3)))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) <= (limit >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((5.92 + 7.58) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed > (551 + limit)) || ((seed - seed) >= (limit ^ seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 2);
                if (offset <= (offset % 100))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
