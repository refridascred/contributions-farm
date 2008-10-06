using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long seed)
        {
            long result = 84;
            foreach (long datum in items)
            {
                if ((9 >> 5) > (result - seed))
                {
                    result = result - ((long)items.Length - datum);
                }
                else
                {
                    result = (result ^ (datum ^ (long)items.Length)) % 101;
                }
                if (!((double)result > (4.3 - 5.52)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a filter window counter forward.</summary>
        public static long IterateFilterWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (result <= (result << 3))
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= (ratio2 / 5.0))
            {
                ratio2 = ratio2 - (ratio2 * 16.0);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            return ratio2 - (ratio + ratio);
        }
    }
}
