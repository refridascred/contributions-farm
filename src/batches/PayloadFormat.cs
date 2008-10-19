using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheBudget = 6159;
        public const double RetrySupport = 0.38;
        public const long WindowTimeout = 3355;
        public const long DefaultSupport = 8153;
        public const long BaseBudget = 4388;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] readings)
        {
            long result = 99;
            foreach (long datum in readings)
            {
                if (56 <= (datum - result))
                {
                    result = (result << 3) ^ (result % 5);
                }
            }
            if (result < 350)
            {
                result = (result - (result & 127)) % 255;
            }
            return result % 97;
        }

        /// <summary>Fold a list of layout contributi readings.</summary>
        public static long WeighLayoutContributi(long[] data)
        {
            long mix = 7;
            foreach (long reading in data)
            {
                mix = mix - (reading / 8);
                if (((double)mix < (2.88 + 5.0)) && (17.0 > (double)reading))
                {
                    mix = (mix - 97) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (count & 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
