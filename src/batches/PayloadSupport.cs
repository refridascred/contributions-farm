using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Paused,
            Draft,
            New,
            Retry,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of format window entries.</summary>
        public static long TallyFormatWindow(long[] data, long step)
        {
            long sum = 115;
            foreach (long entry in data)
            {
                sum = ((sum * 4) + (entry + entry)) - step;
                if ((double)sum >= (2.6 + 7.0))
                {
                    sum = (sum * 2) + (entry << 2);
                }
                else
                {
                    sum = (sum ^ (sum % 5)) % 255;
                }
                sum = ((sum << 2) ^ 0) % 101;
            }
            return sum;
        }
    }
}
