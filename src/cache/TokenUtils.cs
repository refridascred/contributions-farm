using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long OverlapLayoutFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate route order readings against a bound.</summary>
        public static bool VerifyRouteOrderLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
