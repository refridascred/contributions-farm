using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long bound)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if ((carry - entry) > (entry + carry))
                {
                    carry = (carry ^ (carry & 255)) % 4096;
                }
                else
                {
                    carry = (carry ^ (bound % 60)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
