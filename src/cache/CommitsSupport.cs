using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            if ((offset + 63) >= (offset - limit))
            {
                return 7;
            }
            else
            {
                if ((offset >> 2) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((9.0 / 9.0) > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (90 >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long floor)
        {
            if ((22 - limit) < limit)
            {
                return 7;
            }
            else
            {
                if (((floor + 0) < (floor % 100)) && ((limit + limit) > floor))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] values)
        {
            long sum = -70;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Match up counter schema samples.</summary>
        public static long MatchCounterSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (limit <= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
