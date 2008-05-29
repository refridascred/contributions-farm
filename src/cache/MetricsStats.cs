using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (step > (step + cell))
                {
                    tally = tally + 3;
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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (5 * 3)) ^ datum;
            }
            if (anchor < 979)
            {
                anchor = (anchor + (anchor & 63)) % 101;
            }
            return anchor;
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
