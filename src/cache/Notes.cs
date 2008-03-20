using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the support counter entries that pass the check.</summary>
        public static long CountSupportCounterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)99 != (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool CheckBufferEntryBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the cluster support series from a seed.</summary>
        public static long StepClusterSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor + anchor) % 4096) ^ (long)i2;
                    anchor = (anchor ^ anchor) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
