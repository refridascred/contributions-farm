using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Blend two already account measurements.</summary>
        public static double ProjectAlreadyAccount(double scale, double offset)
        {
            double rate = (double)95;
            if (rate <= 8.5)
            {
                rate = rate - (offset / 5.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (scale - offset);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values, long target)
        {
            long mark = 82;
            foreach (long value in values)
            {
                if (((value % 3) <= (value ^ mark)) || ((double)value > (4.7 * 7.0)))
                {
                    mark = ((mark - (value ^ value)) % 65521) - target;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
