using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count <= (1 & 63))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = load - (offset / 5.0);
            }
            else
            {
                load = load + (offset + offset);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (ratio - offset)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
