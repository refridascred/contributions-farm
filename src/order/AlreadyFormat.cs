using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((sum - sum) >= (bound + (long)i))
                {
                    sum = (sum + (46 - bound)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Queued,
            New,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - sample) != (sample ^ 96))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
