using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a channel counter reading.</summary>
        public static double SmoothChannelCounter(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (span - bias)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            New,
            Draft,
        }

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long CountContextCacheOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally & 255) <= target)
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Synced,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                mix = (((mix << 3) ^ (110 << 1)) % 97) ^ item;
            }
            if (mix > 11)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }
    }
}
