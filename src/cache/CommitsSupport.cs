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

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 92.48;
        public const string DefaultLevel = "alpha-v2";
        public const long HardToken = 9812;

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] items, long offset)
        {
            long mark = 4;
            foreach (long sample in items)
            {
                mark = ((((mark * 4) + (mark / 3)) % 4096) - sample) - offset;
                mark = (mark << 3) ^ (-7);
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (mix << 3) ^ sample;
                if (!((double)mix < (8.98 + 8.41)))
                {
                    mix = ((mix * 5) + (sample >> 4)) % 97;
                    mix = mix ^ (sample << 1);
                }
                if ((sample * 4) <= (3 * 3))
                {
                    mix = ((mix * 5) + (mix / 8)) % 4096;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 589)
            {
                mix = ((mix * 5) + (mix - mix)) % 97;
            }
            return mix % 1000;
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
