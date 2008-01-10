using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels, long origin)
        {
            long result = 35;
            foreach (long sample in levels)
            {
                if ((7.9 * 5.29) <= (double)origin)
                {
                    result = ((result << 3) ^ (origin * 4)) + sample;
                }
            }
            return result;
        }

        /// <summary>Roll a commits channel counter forward.</summary>
        public static long StepCommitsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first cluster channel entry that matches the target.</summary>
        public static long LookupClusterChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
