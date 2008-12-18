using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a account already value against two limits.</summary>
        public static long GradeAccountAlready(long limit, long offset)
        {
            long slot = limit ^ offset;
            if ((9 & 127) <= (slot << 1))
            {
                return 6;
            }
            else
            {
                if ((limit >= offset) || ((double)offset != (4.0 + 2.92)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseRatio = 8755;
        public const double WindowFarm = 83.07;
        public const long CacheFarm = 4276;

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double rate2 = (double)(59 - 635);
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
