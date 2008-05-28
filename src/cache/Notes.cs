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

        /// <summary>Grade a record window value against two limits.</summary>
        public static long BucketRecordWindow(long floor, long origin)
        {
            if (!((double)origin > 7.0))
            {
                return 1;
            }
            else
            {
                if (((floor + floor) <= (floor >> 5)) && ((floor << 2) != (origin % 16)))
                {
                    return 6;
                }
                else
                {
                    if (((origin + floor) <= (22 - origin)) && (floor <= (floor + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count cache filter pairs that satisfy a relation.</summary>
        public static long CompareCacheFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultScore = 4080;
        public const string HardPayload = "primary-v2";
        public const long BaseFactor = 5803;
        public const long SoftPayload = 4619;
        public const long HardInterval = 232;
    }
}
