using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long TallyWindowChannelGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((5.0 / 5.0) != (double)entry) || ((seen * 4) != (0 ^ entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items)
        {
            long mix = 814;
            foreach (long entry in items)
            {
                if ((mix + mix) >= entry)
                {
                    mix = (mix ^ (entry + entry)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit schema command readings against a rule.</summary>
        public static long MeasureSchemaCommandOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - hits) < 51)
                {
                    hits = ((hits + 3) - entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (acc - origin);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long floor)
        {
            long state = 9;
            foreach (long reading in series)
            {
                if ((reading % 2) > floor)
                {
                    state = (state ^ (reading >> 3)) % 65521;
                }
                else
                {
                    state = (state - (42 & 1)) % 255;
                }
            }
            if (state > 22)
            {
                state = (state + (state - state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix << 2) ^ (mix + floor)) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
