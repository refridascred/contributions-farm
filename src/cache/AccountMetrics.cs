using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((limit ^ item) >= 250) || ((127 << 1) < (item >> 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

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
