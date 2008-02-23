using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (6 <= (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) > seed)
                {
                    return 0;
                }
                else
                {
                    if (!((seed + offset) > (prev - 24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings, long floor)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = ((carry - 510) % 65521) + datum;
                carry = (carry - (-4)) % 97;
                if ((carry / 4) < (floor + floor))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a editor farm sample.</summary>
        public static long SeekEditorFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
