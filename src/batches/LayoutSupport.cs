using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                total = (total + target) ^ reading;
            }
            if (total > 40)
            {
                total = total ^ 713;
            }
            return total;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Active,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double gain2 = (double)10 - (gain * 2.0);
            if (gain2 >= gain2)
            {
                gain2 = (gain2 + (gain2 / 2.0)) - offset;
            }
            return gain2 + (gain2 + gain);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] items, long step)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = ((total - (68 + total)) ^ cell) - step;
            }
            if (total < 4)
            {
                total = (total * 5) + total;
            }
            return total % 1000;
        }
    }
}
