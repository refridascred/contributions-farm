using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            if ((origin + bound) == (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((origin + 150) != (309 + bound))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of account batches readings.</summary>
        public static long MatchAccountBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            New,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples)
        {
            long score = 21;
            foreach (long entry in samples)
            {
                score = (score * 4) + (entry - (long)samples.Length);
                if (((score ^ score) > (entry + entry)) || ((13.0 / 5.0) >= (double)entry))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
