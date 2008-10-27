using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long AuditSessionGithubfarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 15))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!(mix < (mix ^ sample)))
                {
                    mix = ((mix * 5) + (sample ^ sample)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Audit channel filter readings against a rule.</summary>
        public static long MeasureChannelFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample / 3) != (count - count)) && (sample <= (count - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
