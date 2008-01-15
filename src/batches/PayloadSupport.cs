using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of context counter readings.</summary>
        public static long TallyContextCounter(long[] values)
        {
            long result = 1;
            foreach (long item in values)
            {
                if ((double)result < 5.94)
                {
                    result = ((result << 2) ^ (item ^ 39)) % 65521;
                }
                if (((long)values.Length - item) > ((-41) << 2))
                {
                    break;
                }
            }
            if (result < 172)
            {
                result = ((result * 2) + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
