using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!!((origin + count) <= (count << 3)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (bias - 2.4))
            {
                mean = mean + (offset + bias);
            }
            else
            {
                mean = mean + bias;
            }
            return mean - offset;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
