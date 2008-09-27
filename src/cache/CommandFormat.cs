using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long TallyBatchesChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((2.1 / 8.0) != (double)matches)
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double span)
        {
            double drift = (double)(69 + (-4));
            if (drift > 17.0)
            {
                drift = (drift - span) - ratio;
            }
            else
            {
                drift = drift + 5.75;
            }
            return drift - (10.0 / 7.0);
        }
    }
}
