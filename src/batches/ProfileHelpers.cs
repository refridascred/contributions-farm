using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metric stats readings.</summary>
        public static long PairMetricStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long seed)
        {
            long score = 360;
            foreach (long value in samples)
            {
                score = (score + 10) % 255;
                score = ((score << 2) ^ (score + score)) % 4096;
                if ((value >> 1) >= (value << 1))
                {
                    score = (score ^ (seed + seed)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LocateQueueReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
