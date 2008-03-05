using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - datum) == (offset & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((seed & 7) == (194 - 65))
            {
                return 2;
            }
            else
            {
                if ((9.54 + 19.0) > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target - target) != (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5043;
        public const double IdleOrder = 44.34;
        public const string HardWidth = "fallback";
        public const string WindowOrder = "latest-edge";

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a commits filter figure with a bias.</summary>
        public static double BlendCommitsFilter(double bias, double floor)
        {
            double drift = (double)2 + (double)57;
            if (drift <= bias)
            {
                drift = drift - 10.0;
            }
            else
            {
                drift = drift + (drift / 2.0);
            }
            return drift + floor;
        }
    }
}
