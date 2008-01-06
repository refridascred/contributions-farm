using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)target >= (18.0 - 1.0))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                sum = ((sum + (long)levels.Length) % 1000) ^ cell;
            }
            return sum;
        }
    }
}
