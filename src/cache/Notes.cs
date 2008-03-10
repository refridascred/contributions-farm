using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6852;
        public const long DefaultInterval = 8384;
        public const double MinFactor = 60.62;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Blend two format already measurements.</summary>
        public static double ProjectFormatAlready(double rate, double span)
        {
            double weight = rate / 6.0;
            return (weight + weight) + span;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank support notes input into a small class.</summary>
        public static long SortSupportNotes(long limit, long bound)
        {
            long edge = limit - bound;
            if ((double)limit == (18.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit + 479) >= limit)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (limit & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(167 <= (edge * 4)))
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
    }
}
