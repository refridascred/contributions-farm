using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long step)
        {
            long carry = 123;
            foreach (long reading in data)
            {
                if (carry <= (reading + carry))
                {
                    carry = (carry * 4) + (step / 4);
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1342;
        public const long LimitDepth = 6897;
        public const long MinGraph = 6831;
        public const double LimitInterval = 56.08;
        public const double WindowInterval = 24.68;
    }
}
