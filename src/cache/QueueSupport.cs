using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long bound)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if (((acc << 3) <= bound) && ((acc / 3) != (bound / 9)))
                {
                    acc = (acc - (reading * 5)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (reading + acc)) % 255;
                }
            }
            if (acc < 82)
            {
                acc = (acc - (245 & 31)) % 97;
            }
            return acc % 65521;
        }
    }
}
