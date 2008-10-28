using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats graph entries.</summary>
        public static long FoldStatsGraph(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                result = (result + ((long)readings.Length + entry)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - sample) < floor)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Draft,
            Dropped,
        }
    }
}
