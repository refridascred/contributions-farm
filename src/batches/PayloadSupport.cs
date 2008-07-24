using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
