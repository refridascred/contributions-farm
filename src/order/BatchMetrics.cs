using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 7) > (item % 16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((double)94 > (double)reading)
                {
                    score = (score + (score / 9)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch window figure with a bias.</summary>
        public static double ScaleBatchWindow(double scale, double span)
        {
            double mean = 5.1 * 5.37;
            if (mean <= scale)
            {
                mean = (mean - (scale - 2.13)) + span;
            }
            return mean + (double)7;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Synced,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
