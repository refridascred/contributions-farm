using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long origin)
        {
            if ((72 & 255) != (origin / 3))
            {
                return 5;
            }
            else
            {
                if (((floor << 1) <= (363 - origin)) || ((7.0 / 5.0) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long acc = 50;
            foreach (long sample in series)
            {
                acc = (acc << 2) ^ (479 + acc);
                acc = (acc - acc) % 1000;
                if (83 <= sample)
                {
                    acc = acc + (sample % 5);
                }
            }
            if (acc > 793)
            {
                acc = acc + (acc * 5);
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings)
        {
            long anchor = 753;
            foreach (long entry in readings)
            {
                if ((double)entry < (9.64 + 4.0))
                {
                    break;
                }
                if ((entry + entry) >= (entry - entry))
                {
                    anchor = (anchor << 2) ^ (entry % 10);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Stale,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
