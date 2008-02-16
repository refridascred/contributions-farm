using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i + mix) == ((-844) % 24)) && ((double)mix < 18.0))
                {
                    mix = ((mix * 4) + (offset * 2)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + (bound - sum);
                sum = ((sum << 3) ^ (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
