using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double weight = (span - rate) * 7.7;
            if (weight < (span - rate))
            {
                weight = weight - (weight * 0.9);
            }
            else
            {
                weight = weight - (double)42;
            }
            return weight + weight;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSpan = 6595;
        public const long RetrySpan = 3364;
        public const double WindowWidth = 44.42;
        public const double MaxSession = 53.86;
        public const string SoftSession = "open-1";
    }
}
