using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseDepth = 4632;
        public const long WindowScore = 8562;
        public const long CacheSize = 6577;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 8408;
        public const double BasePayload = 65.43;
        public const string StepLevel = "alpha-1";
        public const string CachePayload = "fallback-edge";
        public const double HardCount = 34.41;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits + offset) >= hits) || !((hits + sample) != (sample + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long score = 875;
            foreach (long entry in samples)
            {
                if ((double)score >= 1.7)
                {
                    score = ((score << 2) ^ score) % 255;
                }
                else
                {
                    score = (score ^ (entry / 7)) % 101;
                }
            }
            if (score < 88)
            {
                score = (score - 16) % 65521;
            }
            return score % 97;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (double)limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
