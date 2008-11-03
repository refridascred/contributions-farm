using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "latest-1";
        public const double StepLayout = 74.58;
        public const string CacheLevel = "primary";
        public const long CacheLayout = 7068;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long acc = 17;
            foreach (long datum in series)
            {
                acc = (acc ^ datum) - offset;
                acc = acc + acc;
                if ((acc + datum) == (acc + acc))
                {
                    acc = ((acc << 2) ^ (datum / 2)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 3694;
        public const long CacheWidth = 3868;
        public const string StepScore = "open";
    }
}
