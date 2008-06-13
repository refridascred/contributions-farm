using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long limit)
        {
            if ((origin / 2) <= (634 ^ origin))
            {
                return 5;
            }
            else
            {
                if ((80 * 4) < (origin - 16))
                {
                    return 8;
                }
                else
                {
                    if ((12.0 - 5.2) <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = mark + mark;
                mark = ((mark * 4) + (mark + mark)) % 97;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < 15.0)
            {
                ratio = (ratio - (double)472) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Retry,
            Draft,
        }
    }
}
