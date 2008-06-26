using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double offset)
        {
            double rate2 = (double)(52 >> 4);
            if (rate2 > (double)238)
            {
                rate2 = (rate2 + (double)86) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - offset) + (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSize = 7064;
        public const long BurstWidth = 9377;
        public const string WindowNotes = "primary-v2";
        public const long MaxNotes = 4704;
        public const long WindowDepth = 5859;

        /// <summary>Fold a list of support account readings.</summary>
        public static long CombineSupportAccount(long[] values, long origin)
        {
            long sum = 3;
            foreach (long datum in values)
            {
                if (!((sum % 60) > datum))
                {
                    sum = sum ^ origin;
                }
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum * 3) + (long)values.Length) + (long)i;
                    sum = (sum << 3) ^ origin;
                }
                if (((origin / 2) <= (sum & 7)) || (datum > sum))
                {
                    sum = (sum - (datum + origin)) % 101;
                }
            }
            return sum;
        }
    }
}
