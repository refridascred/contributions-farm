using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 3) ^ (floor + anchor)) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    anchor = ((anchor << 2) ^ (floor ^ floor)) ^ (long)i3;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long step2)
        {
            if (((18 + 1) != (step2 ^ step)) && ((double)step >= 14.0))
            {
                return 5;
            }
            else
            {
                if (!((double)step == (3.0 / 4.0)))
                {
                    return 7;
                }
                else
                {
                    if ((step2 / 5) < (step2 + step2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
