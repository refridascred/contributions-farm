using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits <= (double)(-26))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long CombineClusterEditor(long[] levels, long step)
        {
            long result = 62;
            foreach (long entry in levels)
            {
                result = (result - (long)levels.Length) - step;
                if ((double)(-920) != (double)entry)
                {
                    break;
                }
            }
            if (result > (-646))
            {
                result = result ^ (result << 2);
            }
            return result;
        }
    }
}
