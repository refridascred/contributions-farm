using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long mix = 487;
            foreach (long sample in samples)
            {
                mix = mix ^ (mix << 1);
                if ((1.2 / 6.0) >= (double)sample)
                {
                    mix = ((mix << 3) ^ target) % 101;
                }
            }
            if (mix < 767)
            {
                mix = ((mix << 2) ^ (target - 1)) % 65521;
            }
            return mix;
        }
    }
}
