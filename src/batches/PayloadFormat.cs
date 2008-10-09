using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long offset)
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + hits) < (cell - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Combine channel layout values into a single score.</summary>
        public static long TotalChannelLayout(long[] items)
        {
            long score = 0;
            foreach (long sample in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score ^ (score & 63)) % 4096) + (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score - (-8)) % 97) - (long)i2;
                }
                if ((2.0 / 8.0) >= (double)sample)
                {
                    score = (score ^ score) % 101;
                }
            }
            return score % 1000;
        }
    }
}
