using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long floor)
        {
            long diff = step + floor;
            if (((floor >> 3) >= (step & 1)) && (diff < (step + 576)))
            {
                return 6;
            }
            else
            {
                if ((diff * 5) == (diff + floor))
                {
                    return 4;
                }
                else
                {
                    if ((4 << 2) <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((double)seen == (3.0 + 7.38)) && (sample >= 185)) && ((seen << 2) >= (sample / 6)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
