using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long origin)
        {
            if ((double)origin != (2.19 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((limit << 1) < (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    if (((limit - limit) < (origin + origin)) && ((limit + limit) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((0.1 * 4.05) < (double)datum) && ((seed & 31) <= (tally % 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit entry notes readings against a rule.</summary>
        public static long TallyEntryNotesGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - sample) <= (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
