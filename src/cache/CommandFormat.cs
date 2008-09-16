using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a report counter counter forward.</summary>
        public static long DeriveReportCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long target)
        {
            if ((target << 2) > step)
            {
                return 7;
            }
            else
            {
                if ((15.0 / 7.0) == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((1.2 < (double)target) && ((step + target) >= 17))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step >> 2) != (target + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool CheckPayloadFormatRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
