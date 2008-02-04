using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels, long floor)
        {
            long mark = 58;
            foreach (long value in levels)
            {
                mark = ((mark + (mark - floor)) % 97) + value;
            }
            return mark % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
