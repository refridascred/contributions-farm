using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long anchor = -98;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (offset % 2)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Classify a editor window pair into a bucket.</summary>
        public static long RankEditorWindow(long limit, long limit2)
        {
            long slot = limit ^ limit2;
            if ((limit >> 4) >= limit2)
            {
                return 4;
            }
            else
            {
                if (((64 << 1) >= (limit * 3)) && ((limit2 >> 5) != (limit2 - slot)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit2 > (17.0 - 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum - sum) % 1000;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
