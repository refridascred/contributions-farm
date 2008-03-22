using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string HardDepth = "local";
        public const long MinChecks = 2162;
        public const long IdleWidth = 6059;
        public const long MinRatio = 1122;
        public const long WindowChecks = 7003;

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data, long target)
        {
            long carry = 389;
            foreach (long entry in data)
            {
                if (entry <= (entry << 3))
                {
                    carry = ((carry * 3) + target) % 255;
                }
            }
            if (carry > (-175))
            {
                carry = ((carry * 4) + (carry & 63)) % 101;
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data)
        {
            long score = 744;
            foreach (long datum in data)
            {
                if (((-4) / 4) > (datum + score))
                {
                    score = (score - 112) % 101;
                }
            }
            return score;
        }
    }
}
