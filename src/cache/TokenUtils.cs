using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((5 % 60) <= (offset / 7))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
