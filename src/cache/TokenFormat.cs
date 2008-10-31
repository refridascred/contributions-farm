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

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9128;
        public const string BaseChannel = "legacy-edge";
        public const long DefaultChannel = 4673;

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
