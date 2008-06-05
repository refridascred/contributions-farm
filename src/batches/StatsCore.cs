using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long anchor = 17;
            foreach (long cell in levels)
            {
                if ((cell + cell) <= (cell * 5))
                {
                    anchor = ((anchor * 5) + (anchor - origin)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long result = -841;
            foreach (long value in readings)
            {
                if (!((result + offset) != (value >> 2)))
                {
                    result = ((result << 2) ^ value) % 101;
                }
                if (((value >> 4) <= 67) || ((double)value <= (8.45 / 5.0)))
                {
                    result = ((result * 3) + offset) % 4096;
                }
            }
            if (result > (-815))
            {
                result = result ^ (offset + 982);
            }
            return result % 65521;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long floor)
        {
            if ((floor & 3) < (floor >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (9.96 + 4.84))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 7) < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry * 5) + (long)i;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
