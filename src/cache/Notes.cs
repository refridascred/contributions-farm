using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long CountPayloadEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample <= (tally << 2)) && ((double)sample != (double)874))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload report value against two limits.</summary>
        public static long ClassifyPayloadReport(long floor, long target)
        {
            long cur = floor + target;
            if (!((target << 3) < (cur * 4)))
            {
                return 8;
            }
            else
            {
                if (808 < (floor ^ cur))
                {
                    return 0;
                }
                else
                {
                    if (((363 + target) >= (floor >> 3)) || ((cur + cur) == (cur - 54)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 3) ^ (result + limit)) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long seed)
        {
            if ((target * 4) == (seed << 2))
            {
                return 5;
            }
            else
            {
                if ((target >> 1) <= (target * 4))
                {
                    return 8;
                }
                else
                {
                    if (5 < (target % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
