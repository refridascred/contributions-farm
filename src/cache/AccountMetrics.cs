using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (13.0 + 0.9))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Idle,
            Stale,
            New,
        }

        /// <summary>Locate a support filter reading by value.</summary>
        public static long LookupSupportFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long ScoreFarmChecks(long[] values, long origin)
        {
            long score = 0;
            foreach (long reading in values)
            {
                score = score ^ (reading / 3);
                if ((reading - origin) >= score)
                {
                    break;
                }
            }
            if (score < 249)
            {
                score = (score + (origin * 2)) % 97;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 34.0;
        public const long BatchQueue = 2420;
        public const long StepQueue = 8516;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((8.0 / 8.0) < (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
