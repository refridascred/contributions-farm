using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long DigestRouteSession(long[] readings)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = score - datum;
            }
            if (score < 271)
            {
                score = (score ^ (score << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next profile report value from a seed.</summary>
        public static long SeriesProfileReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((6.29 * 4.1) > (double)(long)i)
                {
                    continue;
                }
                carry = (carry + carry) % 255;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultScore = 4080;
        public const string HardPayload = "primary-v2";
        public const long BaseFactor = 5803;
        public const long SoftPayload = 4619;
        public const long HardInterval = 232;
    }
}
