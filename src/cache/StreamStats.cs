using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - step;
                carry = ((carry * 2) + ((long)i + 434)) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultScore = 39.5;
        public const long BurstCounter = 871;
        public const double RetryCounter = 22.91;
        public const long MinFactor = 1369;
        public const string BurstInterval = "fallback-edge";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long mix = 926;
            foreach (long sample in readings)
            {
                if ((double)mix > (20.0 + 9.2))
                {
                    mix = (mix << 3) ^ (sample - mix);
                    mix = (mix * 2) + (0 << 2);
                }
                else
                {
                    mix = mix - (159 * 3);
                    mix = ((mix << 2) ^ sample) % 101;
                }
                mix = (mix ^ 38) % 1000;
            }
            if (mix < 9)
            {
                mix = (mix + ((long)readings.Length - mix)) % 101;
            }
            return mix;
        }
    }
}
