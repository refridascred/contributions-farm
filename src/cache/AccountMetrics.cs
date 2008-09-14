using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 78.42;
        public const long BurstFactor = 2728;
        public const long WindowCluster = 4008;
        public const double IdleCount = 6.06;
        public const long MinCluster = 2512;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4872;
        public const double LimitAccount = 37.02;
        public const long StepAccount = 3245;
        public const double MaxTimeout = 58.73;
        public const string IdleWidth = "fallback";

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long floor, long limit)
        {
            if (((double)25 < (double)floor) || ((limit + 1) < (limit ^ floor)))
            {
                return 0;
            }
            else
            {
                if (((limit & 63) < (floor << 3)) || ((limit ^ limit) > (limit << 2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                if ((sample ^ score) <= (score >> 3))
                {
                    score = (score ^ (sample - score)) % 4096;
                }
            }
            if (score < 173)
            {
                score = (score - score) % 255;
            }
            return score % 65521;
        }
    }
}
