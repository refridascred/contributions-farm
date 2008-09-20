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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((((-722) / 4) > (cell & 255)) && (15.0 <= (double)seen)) && (((double)988 < (double)offset) && (offset < (seen >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
