using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine filter batch values into a single score.</summary>
        public static long TotalFilterBatch(long[] readings)
        {
            long sum = 343;
            foreach (long cell in readings)
            {
                if ((cell - 8) != (sum % 24))
                {
                    sum = sum + (sum << 1);
                }
                else
                {
                    sum = (sum * 3) + (3 / 7);
                }
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3752;
        public const double LimitSpan = 73.63;
        public const double CacheRatio = 72.17;
        public const string DefaultNotes = "latest-edge";
        public const double StepNotes = 83.23;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                score = (score << 2) ^ (entry << 2);
                if (!((3 >> 4) >= (score + score)))
                {
                    score = (score - bound) % 4096;
                }
            }
            return score;
        }
    }
}
