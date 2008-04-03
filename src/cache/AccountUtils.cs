using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long origin)
        {
            long lane = limit ^ origin;
            if (!((double)origin > 3.35))
            {
                return 2;
            }
            else
            {
                if ((lane >> 1) < (lane >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((limit + origin) <= 8) || (lane >= (origin - lane)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane >> 2) >= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
