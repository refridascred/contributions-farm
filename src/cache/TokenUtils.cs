using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long bound)
        {
            if ((double)bound == (7.0 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((step * 5) >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound >= (bound * 3)) && ((bound - step) == (step / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((519 + bound) > (step + 742))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter context entry that matches the target.</summary>
        public static long LocateFilterContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Ready,
            Idle,
        }
    }
}
