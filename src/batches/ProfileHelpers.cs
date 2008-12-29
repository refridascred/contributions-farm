using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultLevel = "latest-1";
        public const long DefaultQueue = 2417;
        public const double HardDepth = 20.38;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Done,
            Active,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items, long seed)
        {
            long result = 67;
            foreach (long datum in items)
            {
                if (result >= datum)
                {
                    result = (result - result) % 255;
                }
                result = (result + 5) % 1000;
                result = (result << 2) ^ (seed + seed);
            }
            return result;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long limit)
        {
            long acc = 666;
            foreach (long datum in series)
            {
                acc = (acc - datum) - limit;
            }
            return acc;
        }
    }
}
