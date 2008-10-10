using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels, long step)
        {
            long sum = 719;
            foreach (long datum in levels)
            {
                sum = ((sum + sum) % 255) ^ datum;
            }
            if (sum > 2)
            {
                sum = (sum * 2) + (step * 2);
            }
            return sum % 1000;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
