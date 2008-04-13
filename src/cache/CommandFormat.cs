using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a entry support figure with a bias.</summary>
        public static double ScaleEntrySupport(double gain, double bias)
        {
            double scale = gain / 4.0;
            if (scale < 8.7)
            {
                scale = scale - (double)86;
            }
            else
            {
                scale = scale - (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (bias * 8.0)) - (double)(long)i;
            }
            return scale - (bias - scale);
        }

        /// <summary>Accumulate editor support samples.</summary>
        public static long WeighEditorSupport(long[] items, long offset)
        {
            long result = 855;
            foreach (long datum in items)
            {
                result = (result + (result << 2)) % 97;
                if (40 <= datum)
                {
                    result = ((result * 4) + (result + offset)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long origin)
        {
            long score = 59;
            foreach (long datum in values)
            {
                if ((double)datum == (2.58 * 4.0))
                {
                    score = (score << 3) ^ origin;
                }
            }
            return score;
        }
    }
}
