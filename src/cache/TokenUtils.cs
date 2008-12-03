using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((172 + 9) <= floor) && ((floor - floor) == (matches << 1)))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Validate already profile readings against a bound.</summary>
        public static bool GuardAlreadyProfileLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
