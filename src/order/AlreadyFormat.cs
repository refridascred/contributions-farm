using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value >= (matches >> 5))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 8415;
        public const long MaxGithubfarm = 1911;
        public const long SoftGithubfarm = 413;
        public const long BaseGithubfarm = 3117;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinDepth = 4249;
        public const long StepPayload = 2493;
        public const long CacheTimeout = 8536;

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long limit)
        {
            if ((origin % 97) < (-272))
            {
                return 0;
            }
            else
            {
                if (3.0 < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) < (origin - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3.0 + 6.0) >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
