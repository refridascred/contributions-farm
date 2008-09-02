using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset >= (carry - offset)) || ((3.5 - 5.77) == (double)carry))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate format graph readings against a bound.</summary>
        public static bool GuardFormatGraphLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
