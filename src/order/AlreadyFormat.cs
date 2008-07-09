using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double rate = floor;
            if (rate < rate)
            {
                rate = rate + (6.59 * 8.0);
            }
            else
            {
                rate = rate + 1.26;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (weight + rate)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LookupSessionFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics counter readings against a rule.</summary>
        public static long TallyMetricsCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (91 > tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Idle,
            Active,
            Ready,
            Queued,
        }
    }
}
