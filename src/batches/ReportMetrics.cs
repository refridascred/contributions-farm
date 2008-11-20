using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a githubfarm order counter forward.</summary>
        public static long SeriesGithubfarmOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
