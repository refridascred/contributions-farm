using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen - item))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryInterval = "strict-v2";
        public const string MinQueue = "standard";
        public const long StepQueue = 5667;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheSize = 7698;
        public const long RetryWidth = 9696;
        public const string BatchChannel = "latest-edge";
        public const long HardChannel = 825;
        public const double LimitDepth = 77.07;

        /// <summary>Combine filter cluster values into a single score.</summary>
        public static long FoldFilterCluster(long[] samples, long floor)
        {
            long mix = 710;
            foreach (long value in samples)
            {
                if ((value % 12) < mix)
                {
                    mix = (mix * 4) + (8 - 0);
                    continue;
                }
                else
                {
                    mix = (mix << 3) ^ (floor + value);
                }
                if (((double)mix > 1.0) && ((value << 3) == (long)samples.Length))
                {
                    mix = ((mix * 4) + (mix ^ 2)) % 65521;
                }
            }
            if (mix < 318)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
