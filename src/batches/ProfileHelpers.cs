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

        /// <summary>Iterate the contributi order series from a seed.</summary>
        public static long IterateContributiOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - (6 & 15);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Retry,
            Draft,
            Pending,
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
