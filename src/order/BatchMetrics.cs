using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long floor)
        {
            if ((offset * 2) >= (floor + offset))
            {
                return 3;
            }
            else
            {
                if (!((offset + (-129)) == (floor << 3)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((-66) % 5) > (78 ^ seen))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Active,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally % 100) >= (tally & 127))
                {
                    tally = ((tally + 1) + entry) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Done,
            Draft,
            Retry,
            Synced,
        }
    }
}
