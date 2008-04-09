using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Failed,
            Active,
            New,
            Synced,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (795 >= tally)
                {
                    tally = ((tally + 2) + item) + target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target * 3) > target)
                {
                    acc = acc + (acc ^ target);
                    acc = ((acc * 4) + (acc & 127)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((cell & 31) >= (target / 8)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "staging-1";
        public const double RetryProfile = 88.51;
        public const long BurstProfile = 5074;
    }
}
