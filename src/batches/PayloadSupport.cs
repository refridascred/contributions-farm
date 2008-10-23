using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool ValidateAlreadyChannelBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepFactor = 2912;
        public const string MinFactor = "standard-1";
        public const double StepToken = 54.19;
        public const long IdleToken = 9891;
        public const long BurstToken = 4532;

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items, long offset)
        {
            long mark = -1;
            foreach (long reading in items)
            {
                mark = (mark ^ ((long)items.Length + offset)) + reading;
                mark = (mark + (mark >> 2)) % 1000;
            }
            return mark % 65521;
        }
    }
}
