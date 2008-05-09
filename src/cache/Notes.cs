using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                long slot = result + ((long)i << 1);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    slot = (slot + ((long)i + (-575))) + (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    result = ((result + (slot / 9)) % 4096) - (long)i3;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank filter format input into a small class.</summary>
        public static long GradeFilterFormat(long origin, long target)
        {
            if ((-7) > (origin & 3))
            {
                return 5;
            }
            else
            {
                if ((target / 5) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 5) < (target % 97))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.1 - 4.14) > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long step)
        {
            long edge = offset - step;
            if ((edge + 874) < (offset + edge))
            {
                return 6;
            }
            else
            {
                if ((edge % 5) == (edge & 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
