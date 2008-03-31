using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two support schema measurements.</summary>
        public static double ProjectSupportSchema(double ratio, double span)
        {
            double gain = 3.79;
            if (gain > (span / 4.0))
            {
                gain = gain + 7.7;
            }
            return gain + ratio;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (6.1 <= (double)hits)
                {
                    hits = ((hits + 2) - entry) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next editor layout value from a seed.</summary>
        public static long RollEditorLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = result - bound;
                result = result ^ (bound - bound);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long mix = 868;
            foreach (long datum in items)
            {
                mix = (mix ^ 384) + datum;
                if (((mix & 31) <= (target * 4)) || ((0.63 * 3.7) < (double)target))
                {
                    mix = (mix - (target + 2)) % 97;
                }
                else
                {
                    mix = (mix * 5) + (target + mix);
                }
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long CombineRecordBatch(long[] series, long floor)
        {
            long state = -9;
            foreach (long reading in series)
            {
                if ((0 + reading) > floor)
                {
                    state = ((state << 3) ^ reading) % 1000;
                }
                else
                {
                    state = ((state * 2) + (state + reading)) % 4096;
                }
            }
            return state;
        }
    }
}
