using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading & 255) > origin)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Draft,
            Idle,
            New,
            Failed,
        }

        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long TotalClusterBatches(long[] values)
        {
            long mix = 610;
            foreach (long cell in values)
            {
                if ((cell & 127) <= (mix + mix))
                {
                    mix = mix - (mix + cell);
                    mix = mix - (long)values.Length;
                }
                if ((mix + mix) < (cell * 4))
                {
                    mix = ((mix * 5) + cell) % 101;
                }
            }
            if (mix < 469)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin / 4) <= (origin / 3))
                {
                    mix = (mix ^ (origin ^ 169)) % 255;
                }
                if (((long)i <= mix) && ((7 + mix) < (mix * 2)))
                {
                    break;
                }
                mix = mix - (mix / 4);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
