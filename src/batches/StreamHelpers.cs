using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool VerifyToolsContextRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long floor)
        {
            long next = offset + floor;
            if (((next >> 1) <= (next / 4)) && (offset >= (floor ^ next)))
            {
                return 1;
            }
            else
            {
                if ((floor + next) > (319 / 2))
                {
                    return 6;
                }
                else
                {
                    if (!((next % 16) >= (next ^ next)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(next <= floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format batches samples are out of range.</summary>
        public static long MeasureFormatBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits & 7) < (hits >> 5))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 2) <= (count % 24)) && (8 > (count + entry)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)cell <= (9.01 - 16.0)) && (hits <= (cell & 255)))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
