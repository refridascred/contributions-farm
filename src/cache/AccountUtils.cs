using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long SeekToolsEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 2) ^ (mix - mix);
                mix = (mix ^ (mix * 4)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long MeasureMetricRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) >= (cell % 7)) && ((tally & 255) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
