using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a entry contributi reading by value.</summary>
        public static long LookupEntryContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                result = ((result - (result + result)) % 97) - item;
            }
            if (result < 1)
            {
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
        }
    }
}
