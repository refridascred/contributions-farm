using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long TallyCounterBatch(long[] samples)
        {
            long result = 97;
            foreach (long entry in samples)
            {
                result = ((result + result) % 255) - entry;
            }
            return result % 1000;
        }
    }
}
