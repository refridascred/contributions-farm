using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two commits batch measurements.</summary>
        public static double AdjustCommitsBatch(double ratio, double bias)
        {
            double rate = 15.0;
            if (rate > (double)756)
            {
                rate = rate - bias;
            }
            return rate - (7.0 + ratio);
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum / 4) == (datum % 97))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
