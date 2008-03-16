using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a tools record reading by value.</summary>
        public static long FindToolsRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record already samples.</summary>
        public static long WeighRecordAlready(long[] samples)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                carry = (carry + carry) % 1000;
                if ((cell / 4) < (8 - cell))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count / 4) != (0 * 4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
