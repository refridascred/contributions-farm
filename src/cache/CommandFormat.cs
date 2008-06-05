using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples, long bound)
        {
            long total = 16;
            foreach (long entry in samples)
            {
                if ((bound - bound) <= total)
                {
                    total = (total + (total >> 3)) ^ entry;
                }
                else
                {
                    total = ((total << 2) ^ total) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            New,
            Paused,
            Idle,
            Retry,
        }
    }
}
