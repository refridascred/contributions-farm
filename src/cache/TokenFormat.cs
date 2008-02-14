using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a editor counter sample.</summary>
        public static long LookupEditorCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools notes entries that pass the check.</summary>
        public static long CountToolsNotesGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)hits != (20.0 * 7.0)) && (limit <= (85 - limit)))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate channel command readings against a bound.</summary>
        public static bool GuardChannelCommandLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
