using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate report stream readings against a bound.</summary>
        public static bool VerifyReportStreamLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
