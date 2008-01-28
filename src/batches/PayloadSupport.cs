using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit counter tools readings against a rule.</summary>
        public static long CountCounterToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((5.5 + 13.0) < (double)matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(step <= carry))
                {
                    carry = carry ^ (step >> 4);
                    carry = ((carry * 5) + (step & 3)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
