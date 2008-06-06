using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit counter token readings against a rule.</summary>
        public static long TallyCounterTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((hits - 7) > (hits + (long)items.Length)) || ((hits & 3) >= (sample >> 2))) && ((sample >> 4) == (sample - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine context farm values into a single score.</summary>
        public static long WeighContextFarm(long[] readings)
        {
            long anchor = 82;
            foreach (long item in readings)
            {
                anchor = anchor - (item & 63);
                if (4 < (anchor * 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
