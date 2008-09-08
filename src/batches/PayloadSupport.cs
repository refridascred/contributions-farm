using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long floor)
        {
            if (((-7) - floor) > step)
            {
                return 8;
            }
            else
            {
                if (87 >= floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - 63) == (681 & 31))
                {
                    seen = ((seen + 3) - datum) - bound;
                }
            }
            return seen;
        }
    }
}
