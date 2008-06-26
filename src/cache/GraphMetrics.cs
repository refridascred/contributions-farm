using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (mix + 3);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((entry / 3) <= (entry + count)))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
