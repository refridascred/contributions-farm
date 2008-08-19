using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a support metric pair into a bucket.</summary>
        public static long GradeSupportMetric(long target, long seed)
        {
            if ((seed << 3) < (81 % 12))
            {
                return 2;
            }
            else
            {
                if (!((6.7 - 1.1) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches != (8.94 + 3.43))
                {
                    matches = ((matches + 3) + datum) + origin;
                }
            }
            return matches;
        }

        /// <summary>Blend two contributi filter measurements.</summary>
        public static double AdjustContributiFilter(double rate, double span)
        {
            double drift = (span * 5.5) - rate;
            if (drift <= (span * 2.0))
            {
                drift = drift + (rate + span);
            }
            else
            {
                drift = drift + 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 3.0) - (double)(long)i;
            }
            return drift + (13.0 * 5.5);
        }

        /// <summary>Match up schema account samples.</summary>
        public static long OverlapSchemaAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long MeasureFormatCommandGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches + matches) > (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
