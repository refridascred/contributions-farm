using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i << 2);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
