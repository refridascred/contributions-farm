using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((14.0 - 5.61) != (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double rate, double span)
        {
            double drift = rate;
            if (drift > (3.0 * 2.0))
            {
                drift = (drift - 3.0) - span;
            }
            return drift - (double)59;
        }

        /// <summary>Combine githubfarm entry values into a single score.</summary>
        public static long CombineGithubfarmEntry(long[] values)
        {
            long sum = 973;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (entry / 5)) % 101;
            }
            return sum;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (span - gain);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
