using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (528 >= reading)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long IterateGraphChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result + result) % 101;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
