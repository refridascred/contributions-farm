using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples)
        {
            long carry = 23;
            foreach (long sample in samples)
            {
                if ((carry ^ 441) >= carry)
                {
                    carry = ((carry - carry) % 1000) ^ sample;
                }
                else
                {
                    carry = (carry + carry) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long origin)
        {
            long total = 320;
            foreach (long reading in series)
            {
                if ((origin - total) >= (origin * 3))
                {
                    total = ((total << 2) ^ (total * 2)) - reading;
                }
            }
            if (total < 975)
            {
                total = (total + (origin & 3)) % 101;
            }
            return total;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
