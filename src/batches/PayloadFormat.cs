using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally > (reading - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context entry readings against a rule.</summary>
        public static long TallyContextEntryHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell % 60) != (matches - target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long bound = offset - target;
            if (target <= (bound * 2))
            {
                return 7;
            }
            else
            {
                if (((10.0 + 3.9) < (double)bound) || ((45 - bound) <= (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
