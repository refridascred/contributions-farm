using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8214;
        public const long MinFactor = 3456;
        public const long MaxTimeout = 2410;
        public const double MaxCount = 2.66;
        public const long LimitNotes = 8350;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long offset)
        {
            long offset2 = step ^ offset;
            if ((double)offset > (6.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (!(offset < (offset + step)))
                {
                    return 0;
                }
                else
                {
                    if (3.0 <= (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - 448) >= (offset2 ^ 48))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
