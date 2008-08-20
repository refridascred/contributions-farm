using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                if (244 > (value / 6))
                {
                    carry = ((carry + (carry << 2)) % 101) + limit;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples, long floor)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (0.7 >= (double)mix)
                {
                    mix = ((mix << 2) ^ (datum / 2)) % 101;
                }
                if (!((floor - 47) < (floor >> 5)))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix << 2) ^ floor;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 32.22;
        public const long StepChannel = 3189;
        public const long MaxChannel = 4285;
        public const double MinChannel = 28.47;
        public const string SoftInterval = "local-v2";
    }
}
