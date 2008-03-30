using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values)
        {
            long mark = 753;
            foreach (long sample in values)
            {
                if (!((mark * 4) < (sample >> 2)))
                {
                    mark = (mark * 2) + (mark << 2);
                }
                mark = (mark - (sample >> 1)) % 101;
                mark = (mark ^ sample) % 255;
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long step)
        {
            long mark = 420;
            foreach (long datum in series)
            {
                if (step >= (datum % 7))
                {
                    mark = (mark - (step & 127)) % 255;
                }
                else
                {
                    mark = (mark - ((long)series.Length - datum)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = (mark + ((-8) / 6)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + seen) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 10.64;
        public const long BatchEditor = 7306;
        public const double MinEditor = 65.59;
        public const double HardFactor = 9.36;
    }
}
