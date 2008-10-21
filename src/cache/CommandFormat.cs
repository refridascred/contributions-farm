using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double mean = span;
            if (mean > span)
            {
                mean = mean + 9.15;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)396) + (double)(long)i;
            }
            return mean - (weight - mean);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
