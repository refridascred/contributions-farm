using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool VerifyFilterCommandBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long bound)
        {
            if (((offset & 255) > (offset - offset)) || ((bound + offset) >= bound))
            {
                return 8;
            }
            else
            {
                if (!((bound << 1) < (91 / 2)))
                {
                    return 6;
                }
                else
                {
                    if ((bound + offset) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3.48 / 2.0) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
