using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "local-1";
        public const string SoftBudget = "standard-edge";
        public const long MaxCommand = 4263;
        public const double MinSize = 17.03;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long limit)
        {
            long mix = 444;
            foreach (long item in samples)
            {
                if ((double)mix != (1.4 * 15.0))
                {
                    mix = (((mix << 2) ^ (limit + mix)) % 65521) ^ item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit already cache readings against a rule.</summary>
        public static long MeasureAlreadyCacheOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((target >> 5) < (target ^ 65))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
