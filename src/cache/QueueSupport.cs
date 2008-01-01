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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
