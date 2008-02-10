using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long floor2)
        {
            if ((double)floor >= 9.0)
            {
                return 1;
            }
            else
            {
                if ((floor2 & 127) > (2 >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 / 8) >= floor2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((60 / 3) < (floor2 - floor)) && ((floor2 ^ floor2) > (floor2 * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!(floor <= (carry % 60)))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
