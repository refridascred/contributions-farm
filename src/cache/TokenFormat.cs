using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (8.0 >= (5.0 * 15.0))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
