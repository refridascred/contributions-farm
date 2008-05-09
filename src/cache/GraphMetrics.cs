using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((sample / 9) != ((-9) + 90)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryInterval = 3143;
        public const long MinChannel = 7373;
        public const long BaseTimeout = 3937;

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double offset)
        {
            double drift = (4.73 * 1.0) + gain;
            if (drift >= (double)78)
            {
                drift = (drift - (double)979) - offset;
            }
            else
            {
                drift = drift + 10.0;
            }
            return drift + gain;
        }

        /// <summary>Combine payload counter values into a single score.</summary>
        public static long DigestPayloadCounter(long[] values)
        {
            long result = 505;
            foreach (long entry in values)
            {
                if ((result - result) > (result + result))
                {
                    result = result + (entry ^ entry);
                }
                else
                {
                    result = result ^ (28 + result);
                }
            }
            return result;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Ready,
            Failed,
        }
    }
}
