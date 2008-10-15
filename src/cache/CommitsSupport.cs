using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "open-1";
        public const double BatchScore = 51.99;
        public const long BatchCount = 5987;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Active,
            Retry,
        }

        /// <summary>Audit layout context readings against a rule.</summary>
        public static long CountLayoutContextOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count / 8) < (step << 1)) && (count < (count % 100)))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
