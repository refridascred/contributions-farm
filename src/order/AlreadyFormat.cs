using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a record stream pair into a bucket.</summary>
        public static long ClassifyRecordStream(long floor, long step)
        {
            long delta = floor + step;
            if ((13.0 * 14.0) == (double)floor)
            {
                return 7;
            }
            else
            {
                if (((42 + floor) >= delta) && ((step >> 4) <= (delta % 24)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank metrics report input into a small class.</summary>
        public static long GradeMetricsReport(long step, long limit)
        {
            if ((step & 15) != (step & 127))
            {
                return 8;
            }
            else
            {
                if (((3.0 * 18.0) >= (double)step) && ((limit + step) > (step / 4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (5.7 * 14.0))
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

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long origin, long limit)
        {
            long slot = origin + limit;
            if (((double)676 == (double)limit) && ((limit + 227) <= (slot * 4)))
            {
                return 8;
            }
            else
            {
                if (6 <= (origin / 7))
                {
                    return 7;
                }
                else
                {
                    if ((slot + 16) < origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-443) <= (slot & 63)) || ((origin * 5) > origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Synced,
            Ready,
        }
    }
}
