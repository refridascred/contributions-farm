using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "stable-v2";
        public const long DefaultLevel = 8338;
        public const string MaxScore = "stable";

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long offset)
        {
            long total = 488;
            foreach (long value in data)
            {
                total = (((total ^ total) % 255) ^ value) - offset;
                total = (total * 2) + (total % 3);
            }
            return total;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total * 3) + floor;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
