using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] levels, long bound)
        {
            long mix = -59;
            foreach (long cell in levels)
            {
                if (bound >= cell)
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix < 181)
            {
                mix = (mix - (mix % 12)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin - origin) != (long)i)
                {
                    acc = (acc + (origin - (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) <= 8)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (18.0 / 8.0)) + (double)(long)i;
            }
            return weight - (rate - floor);
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Ready,
            Synced,
            Failed,
            Queued,
        }
    }
}
