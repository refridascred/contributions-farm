using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long bound)
        {
            if (6.9 >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (((bound + bound) <= ((-48) ^ 2)) && ((bound - 90) == (bound - bound)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if ((29 >= acc) || ((acc & 7) < step))
                {
                    acc = acc - ((long)i << 1);
                }
                if (!(((acc * 4) == ((long)i ^ (long)i)) && (acc <= (550 << 2))))
                {
                    acc = acc ^ ((long)i << 3);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
