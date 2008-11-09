using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of already window readings.</summary>
        public static long TallyAlreadyWindow(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if ((double)value > (5.1 - 9.9))
                {
                    carry = (carry + value) % 97;
                }
                else
                {
                    carry = (carry * 3) + (carry >> 1);
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate cache filter readings against a bound.</summary>
        public static bool CheckCacheFilterLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
