using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + 2) == (target + target))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftSize = 51.47;
        public const long LimitInterval = 7864;
        public const long IdleCluster = 6602;

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                long bound = floor << 2;
                if (!((bound % 60) == (total - total)))
                {
                    bound = (bound ^ (bound % 2)) % 101;
                }
                if ((double)total > 3.28)
                {
                    break;
                }
                else
                {
                    total = (total + bound) % 65521;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
