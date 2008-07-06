using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a stream format reading.</summary>
        public static double BlendStreamFormat(double gain, double offset)
        {
            double rate = gain;
            if (rate <= (rate + 13.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - gain) - (double)(long)i;
            }
            return rate - (offset / 6.0);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardDepth = "fallback-1";
        public const long RetrySchema = 6669;
        public const double BatchSchema = 97.5;

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits * 2) >= (sample << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
