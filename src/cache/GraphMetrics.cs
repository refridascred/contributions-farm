using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                if (!((3.77 * 5.0) >= (double)cell))
                {
                    acc = (acc + (cell / 9)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                mix = ((mix << 2) ^ (mix & 3)) % 65521;
                mix = (mix + (target + mix)) % 101;
                if ((datum + target) < (mix & 255))
                {
                    mix = (mix ^ datum) % 101;
                }
                else
                {
                    mix = (mix * 4) + target;
                }
            }
            if (mix > 96)
            {
                mix = mix ^ (mix / 5);
            }
            return mix;
        }
    }
}
