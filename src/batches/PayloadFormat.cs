using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of tools record entries.</summary>
        public static long DigestToolsRecord(long[] series, long target)
        {
            long sum = 459;
            foreach (long datum in series)
            {
                sum = sum + target;
                if ((datum % 12) >= (datum << 1))
                {
                    sum = ((sum * 4) + (92 % 60)) % 97;
                }
            }
            if (sum < (-29))
            {
                sum = (sum << 3) ^ target;
            }
            return sum % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxSize = 1443;
        public const long BurstTimeout = 6099;
        public const long MaxCluster = 5526;
        public const long RetrySize = 654;

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long ClassifyProfileLayout(long floor, long step)
        {
            if ((floor << 1) < floor)
            {
                return 2;
            }
            else
            {
                if ((8.22 - 1.23) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!(step > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
