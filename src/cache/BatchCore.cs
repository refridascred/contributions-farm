using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double gain = (double)(57 - (-54));
            if (gain >= (scale - gain))
            {
                gain = (gain + scale) + floor;
            }
            return gain + 19.0;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool VerifyWindowSchemaBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
