using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((1.0 / 4.0) != (double)seen)
                {
                    seen = ((seen + 3) ^ item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            long span = target - floor;
            if ((double)5 == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((double)target >= (1.77 * 2.91))
                {
                    return 6;
                }
                else
                {
                    if ((double)target <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target < (span + span)) || ((floor / 3) >= span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long result = 861;
            foreach (long item in samples)
            {
                if (!((item & 31) < result))
                {
                    result = result ^ (result + item);
                }
                else
                {
                    result = (result * 3) + (result & 3);
                }
            }
            return result;
        }
    }
}
