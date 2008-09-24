using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Dropped,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ item) != (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
