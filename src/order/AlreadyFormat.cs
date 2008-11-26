using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series, long step)
        {
            long mix = 324;
            foreach (long value in series)
            {
                if (((double)step <= (2.2 * 4.0)) && ((mix + mix) != (value % 97)))
                {
                    break;
                }
                else
                {
                    mix = (mix + 98) % 1000;
                }
                mix = mix - (mix + value);
            }
            return mix % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally > (tally << 1))
                {
                    tally = ((tally + 3) + entry) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum <= (datum * 2))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((double)(long)samples.Length >= 8.14))
                {
                    count = ((count + 3) + cell) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
