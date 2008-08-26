using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - ratio;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3862;
        public const long HardInterval = 9338;
        public const long BaseCount = 6374;
        public const string LimitLevel = "primary-v2";
        public const long BaseCommand = 4486;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (offset >= (seen & 1))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
