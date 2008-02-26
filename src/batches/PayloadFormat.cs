using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series, long step)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if ((step & 7) > (step + 6))
                {
                    mark = ((mark << 2) ^ step) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (value - mark)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long AuditOrderGithubfarmMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum - 23) > (datum % 2)) && ((3 < (datum * 4)) && ((count * 4) > (count - count))))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 5141;
        public const string HardInterval = "standard-edge";
        public const long RetryGraph = 3158;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 349;
        public const long IdleSize = 9172;
        public const long MaxTools = 9740;
    }
}
