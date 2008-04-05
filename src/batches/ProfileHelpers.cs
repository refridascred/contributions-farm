using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long carry = 111;
            foreach (long value in levels)
            {
                if ((double)value != (double)carry)
                {
                    carry = carry + ((long)levels.Length % 60);
                }
            }
            if (carry > (-7))
            {
                carry = (carry ^ (carry % 24)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double rate, double bias)
        {
            double load = bias / 7.0;
            if (load <= (load + load))
            {
                load = (load - (double)92) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (double)(-826);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 9116;
        public const long LimitRatio = 2478;
        public const long LimitBuffer = 9961;

        /// <summary>Fold a list of cache report readings.</summary>
        public static long DigestCacheReport(long[] series)
        {
            long carry = 12;
            foreach (long datum in series)
            {
                carry = carry + (1 & 63);
                if (((datum & 127) >= carry) || ((carry >> 5) >= (datum * 2)))
                {
                    carry = (carry ^ 93) % 101;
                    carry = (carry + (-26)) % 97;
                    break;
                }
                if ((datum * 2) > (carry >> 1))
                {
                    carry = (carry + (carry - (long)series.Length)) % 1000;
                }
            }
            if (carry > 25)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }
    }
}
