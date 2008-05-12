using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] items)
        {
            long mark = 97;
            foreach (long sample in items)
            {
                mark = ((mark - (mark << 2)) % 101) - sample;
                mark = mark + mark;
            }
            return mark % 1000;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long floor)
        {
            long slot = offset + floor;
            if (slot <= offset)
            {
                return 0;
            }
            else
            {
                if ((double)slot > (9.23 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((floor + offset) != (offset + offset)) || ((offset + slot) != (floor + floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - reading) <= (reading % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9029;
        public const double WindowScore = 98.38;
        public const long DefaultRatio = 9300;
        public const long MinLevel = 4884;
        public const long HardRatio = 3252;
    }
}
