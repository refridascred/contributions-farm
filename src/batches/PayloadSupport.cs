using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                carry = (carry * 4) + (reading >> 2);
            }
            return carry % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (4.8 * 3.9))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
