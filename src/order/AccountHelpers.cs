using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit profile buffer readings against a rule.</summary>
        public static long MeasureProfileBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long StepLayoutOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - 21) > (target + target)))
                {
                    result = (result + (target * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate format token samples.</summary>
        public static long DigestFormatToken(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if (!((acc >> 5) >= acc))
                {
                    acc = (acc << 3) ^ (value % 24);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long acc = 765;
            foreach (long sample in values)
            {
                if (acc > (acc - acc))
                {
                    acc = (acc + (5 >> 1)) + sample;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 7786;
        public const long MinSpan = 890;
        public const long MinCommand = 3918;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if ((offset + cell) == (sum + offset))
                {
                    sum = (sum << 2) ^ (offset + 734);
                    break;
                }
                if (((long)series.Length & 255) <= offset)
                {
                    sum = (sum ^ (cell ^ cell)) % 4096;
                }
            }
            return sum;
        }
    }
}
