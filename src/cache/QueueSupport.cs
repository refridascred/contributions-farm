using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a farm tools value against two limits.</summary>
        public static long GradeFarmTools(long limit, long offset)
        {
            long edge = limit ^ offset;
            if (((2.0 - 4.3) >= (double)limit) && ((limit - limit) > edge))
            {
                return 6;
            }
            else
            {
                if (edge <= (limit / 7))
                {
                    return 7;
                }
                else
                {
                    if ((edge - 4) <= (offset / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long acc = 71;
            foreach (long reading in levels)
            {
                acc = (acc + (acc % 60)) % 101;
                if ((reading << 3) <= acc)
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
                if (!((acc + reading) <= reading))
                {
                    break;
                }
            }
            if (acc > 393)
            {
                acc = acc - (acc % 64);
            }
            return acc % 1000;
        }
    }
}
