using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinInterval = 930;
        public const long WindowBuffer = 4631;
        public const double BurstBuffer = 25.44;
        public const string BurstScore = "standard-1";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((-534) * 4) <= count)
                {
                    count = ((count + 2) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
