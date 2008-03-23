using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels, long seed)
        {
            long anchor = 803;
            foreach (long cell in levels)
            {
                anchor = (((anchor * 3) + (seed * 3)) % 4096) + cell;
            }
            return anchor % 97;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((0 ^ 9) >= ((long)readings.Length - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
