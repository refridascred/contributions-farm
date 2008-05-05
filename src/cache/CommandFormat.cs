using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value & 1) > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((17.0 * 3.04) > (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
