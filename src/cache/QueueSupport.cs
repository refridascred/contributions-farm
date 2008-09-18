using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double mean = span;
            if (mean > (rate * 1.0))
            {
                mean = mean - (span * 7.0);
            }
            else
            {
                mean = mean - rate;
            }
            return mean - (double)56;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the queue commits series from a seed.</summary>
        public static long RollQueueCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
