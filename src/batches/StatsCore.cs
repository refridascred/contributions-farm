using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a account support reading.</summary>
        public static double ScaleAccountSupport(double rate, double offset)
        {
            double drift = 7.4;
            if (drift < (double)34)
            {
                drift = (drift + offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)955) - (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Idle,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Measure how many account context samples are out of range.</summary>
        public static long AuditAccountContextGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((floor + 8) > (long)values.Length)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits contributi pair into a bucket.</summary>
        public static long BucketCommitsContributi(long offset, long step)
        {
            if ((offset - step) != (offset >> 3))
            {
                return 0;
            }
            else
            {
                if ((6.7 * 2.0) > (8.4 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long MeasureCounterMetricsMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item / 8) < (41 / 9))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Synced,
            Ready,
            Done,
            Idle,
        }
    }
}
