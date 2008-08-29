using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheCount = 48.33;
        public const long MinWindow = 9590;
        public const long BatchLevel = 7603;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data)
        {
            long total = 955;
            foreach (long datum in data)
            {
                if (datum >= (total >> 4))
                {
                    total = ((total << 2) ^ datum) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of order already entries.</summary>
        public static long WeighOrderAlready(long[] samples, long bound)
        {
            long anchor = 82;
            foreach (long reading in samples)
            {
                if ((anchor & 63) != (reading % 97))
                {
                    anchor = (anchor ^ (reading * 4)) - bound;
                }
            }
            if (anchor > (-75))
            {
                anchor = anchor + (713 % 3);
            }
            return anchor;
        }
    }
}
