using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long limit, long offset)
        {
            if (((limit - offset) <= offset) || ((double)limit >= (double)(-25)))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (6.5 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < (7.07 - 6.5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit & 1) >= (limit / 6)) || ((887 + offset) <= (offset + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
