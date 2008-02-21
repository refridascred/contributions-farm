using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long offset)
        {
            long anchor = 87;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 3) + (offset * 3)) ^ cell;
            }
            return anchor;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a batches contributi value against two limits.</summary>
        public static long RankBatchesContributi(long bound, long seed)
        {
            if ((double)9 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((8.9 / 3.0) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long TallyProfileChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((11.0 + 3.0) < (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
