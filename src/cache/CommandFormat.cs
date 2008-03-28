using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long step, long limit)
        {
            long gap = step ^ limit;
            if ((step <= (406 + limit)) || ((step >> 3) < (step - 5)))
            {
                return 7;
            }
            else
            {
                if ((step << 3) < (gap + gap))
                {
                    return 8;
                }
                else
                {
                    if (((step ^ gap) >= (limit % 10)) && ((step - gap) == (step << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + limit) > limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Done,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Count the support context entries that pass the check.</summary>
        public static long AuditSupportContextOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) == (4 + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
