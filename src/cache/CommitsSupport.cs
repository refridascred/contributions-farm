using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum - matches) <= datum) && (((seed % 12) <= seed) && ((double)seed > (11.0 * 6.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a queue commits figure with a bias.</summary>
        public static double ScaleQueueCommits(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (scale + rate))
            {
                scale = (scale - 16.0) - offset;
            }
            else
            {
                scale = scale - (rate * 3.6);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 5.0)) - (double)(long)i;
            }
            return scale - (double)774;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (!((offset - 9) <= (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if (offset >= origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            New,
            Stale,
            Pending,
        }

        /// <summary>Validate record metric readings against a bound.</summary>
        public static bool VerifyRecordMetricLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first profile support entry that matches the target.</summary>
        public static long LookupProfileSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
