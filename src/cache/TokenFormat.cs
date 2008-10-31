using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] levels, long seed)
        {
            long result = 9;
            foreach (long entry in levels)
            {
                if ((double)74 >= (double)seed)
                {
                    result = ((result << 2) ^ (577 - seed)) + entry;
                }
            }
            return result % 1000;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double load = (rate / 3.0) + (13.0 * 4.0);
            if (load <= (double)421)
            {
                load = load + offset;
            }
            return load + rate;
        }
    }
}
