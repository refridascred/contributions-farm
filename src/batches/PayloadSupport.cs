using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double gain = offset;
            return gain - bias;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
