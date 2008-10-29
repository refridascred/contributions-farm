using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate session record samples.</summary>
        public static long ScoreSessionRecord(long[] values, long target)
        {
            long state = 5;
            foreach (long cell in values)
            {
                if ((state % 16) >= (502 - 51))
                {
                    state = ((state << 3) ^ (cell - target)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result - ((-67) & 255)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally % 100) > reading) || (tally > (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
