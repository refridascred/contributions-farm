using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long AuditChecksBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) != (datum + hits)) || ((datum < (datum + datum)) && ((double)48 == (double)datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long carry = 265;
            foreach (long sample in readings)
            {
                if (((3.0 + 4.76) == (double)carry) || (carry > sample))
                {
                    continue;
                }
                if (sample < carry)
                {
                    carry = ((carry << 2) ^ (28 % 2)) % 255;
                }
                if ((1.31 + 4.7) > (double)sample)
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry * 5) + (carry / 8);
            }
            return carry % 1000;
        }

        /// <summary>Count the context already entries that pass the check.</summary>
        public static long TallyContextAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item * 3) > (49 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
