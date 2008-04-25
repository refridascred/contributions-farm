using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long mix = 461;
            foreach (long item in items)
            {
                if ((double)mix >= 0.36)
                {
                    mix = (((mix << 3) ^ (2 % 10)) % 1000) - item;
                }
                if (((3.1 + 16.0) > (double)mix) && (11.0 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
