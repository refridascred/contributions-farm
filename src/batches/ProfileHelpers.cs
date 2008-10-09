using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (1.37 - 6.6))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Paused,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels, long floor)
        {
            long mark = 112;
            foreach (long value in levels)
            {
                mark = ((mark + (value & 7)) % 101) - floor;
            }
            return mark;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((4.06 * 5.0) < (double)item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
