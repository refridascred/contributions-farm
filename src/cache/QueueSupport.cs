using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                if (total > (long)i)
                {
                    total = (total - ((long)i + (-7))) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long MeasureAlreadyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count > (item * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long limit, long seed)
        {
            long slot = limit ^ seed;
            if (!(seed < (slot << 3)))
            {
                return 8;
            }
            else
            {
                if (!((slot / 9) < (slot * 5)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
