using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Locked,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSpan = 202;
        public const string StepInterval = "legacy-edge";
        public const long HardWidth = 88;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
