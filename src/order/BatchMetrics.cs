using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double scale = weight / 7.0;
            if (scale >= offset)
            {
                scale = scale - 20.0;
            }
            return scale - scale;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(item <= (item - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
