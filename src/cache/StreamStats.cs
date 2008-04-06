using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long total = 964;
            foreach (long sample in values)
            {
                if (step >= sample)
                {
                    total = total + (78 - sample);
                }
                else
                {
                    total = (total << 3) ^ (step + sample);
                    total = total - (total ^ total);
                }
                total = (total * 2) + ((-1) + total);
                total = total ^ (total >> 2);
                if ((639 % 7) != (total & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the notes stats entries that pass the check.</summary>
        public static long CountNotesStatsGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits >= 8.7)
                {
                    hits = ((hits + 1) ^ item) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((13.0 * 0.4) > (double)seed)
                {
                    total = (total * 3) + seed;
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
