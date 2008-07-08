using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ (result * 2)) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool CheckChecksFarmRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
