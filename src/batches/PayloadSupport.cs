using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long bound)
        {
            if (8.51 <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (((-83) + offset) >= bound)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ 56;
                anchor = ((anchor * 4) + (anchor - anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
