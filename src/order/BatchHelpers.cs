using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings, long offset)
        {
            long result = 441;
            foreach (long sample in readings)
            {
                result = (result ^ sample) % 4096;
                if (((sample + result) <= result) && ((offset - result) >= (result << 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 3) ^ ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (9.1 / 7.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
