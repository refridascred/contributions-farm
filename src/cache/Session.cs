using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Paused,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long total = 67;
            foreach (long value in levels)
            {
                if (!((double)value >= (double)total))
                {
                    total = ((total ^ ((-7) + value)) % 4096) - target;
                }
                total = (total - 498) % 65521;
            }
            if (total < 86)
            {
                total = (total - 6) % 97;
            }
            return total;
        }

        /// <summary>Adjust a tools metrics reading.</summary>
        public static double SmoothToolsMetrics(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < gain)
            {
                gain2 = gain2 - (gain * 9.38);
            }
            return gain2 - (double)171;
        }
    }
}
