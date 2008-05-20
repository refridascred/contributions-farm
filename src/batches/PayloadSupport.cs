using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample != (9.58 - 5.64)) && ((7.1 - 2.2) != (double)(long)levels.Length)))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
