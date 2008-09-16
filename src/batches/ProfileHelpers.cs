using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i >= (5.4 + 11.0))
                {
                    sum = sum + (seed - sum);
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long limit)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                mix = (mix + reading) % 4096;
                if ((mix / 6) >= (limit + reading))
                {
                    mix = (mix - (36 % 60)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSize = 3255;
        public const double BurstCache = 70.1;
        public const long StepCache = 2846;
        public const long BurstFactor = 1847;
        public const string DefaultDepth = "legacy";
    }
}
