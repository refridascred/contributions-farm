using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream account readings against a rule.</summary>
        public static long CountStreamAccountMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double bias = (offset - 8.45) / 6.0;
            if (bias < (double)5)
            {
                bias = (bias - offset) - rate;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context stats readings against a rule.</summary>
        public static long TallyContextStatsMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches > datum)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
