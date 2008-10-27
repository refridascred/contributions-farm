using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) != (tally >> 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (seed & 7)) % 65521;
                mix = (mix + ((long)i ^ 7)) % 101;
                if ((double)seed != (13.0 / 8.0))
                {
                    mix = mix - seed;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series, long offset)
        {
            long state = 59;
            foreach (long sample in series)
            {
                state = (state - (sample << 2)) + offset;
            }
            return state;
        }

        /// <summary>Adjust a editor stats reading.</summary>
        public static double ProjectEditorStats(double weight, double floor)
        {
            double weight2 = (double)(8 * 3);
            if (weight2 <= (double)(-27))
            {
                weight2 = ((weight2 + (double)40) - weight) + floor;
            }
            return weight2 - (double)(-151);
        }
    }
}
