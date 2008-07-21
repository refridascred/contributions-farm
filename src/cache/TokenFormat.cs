using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((2.4 * 17.0) == (double)count)
                {
                    count = ((count + 3) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)(-417) >= (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                acc = ((acc * 3) + (acc % 60)) % 4096;
                if ((574 * 5) < (acc + acc))
                {
                    acc = ((acc << 3) ^ (reading / 5)) % 65521;
                }
                if (((3.3 - 5.0) >= (double)reading) && ((-4) < (acc - acc)))
                {
                    acc = ((acc << 2) ^ (77 & 63)) % 4096;
                }
            }
            return acc % 1000;
        }
    }
}
