using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long step, long step2)
        {
            if ((step2 <= step) && ((step2 - step2) == (step & 127)))
            {
                return 3;
            }
            else
            {
                if (456 <= (step2 % 60))
                {
                    return 0;
                }
                else
                {
                    if ((773 ^ step2) > (step & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
