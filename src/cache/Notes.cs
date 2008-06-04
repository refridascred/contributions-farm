using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((4 >= (limit - limit)) && ((reading % 2) <= limit))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Audit context metric readings against a rule.</summary>
        public static long CountContextMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen / 9) > 56)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a layout batches counter forward.</summary>
        public static long DeriveLayoutBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i == (anchor << 1))
                {
                    anchor = (anchor * 3) + (anchor & 7);
                    anchor = (anchor << 3) ^ (long)i;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 1000) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
