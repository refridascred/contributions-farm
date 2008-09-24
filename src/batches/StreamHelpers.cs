using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value << 1) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double ratio = span;
            return (ratio + (span * 3.1)) + gain;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (710 >= (item + item))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Dropped,
            Active,
        }
    }
}
