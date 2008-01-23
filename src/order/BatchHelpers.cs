using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long acc = -60;
            foreach (long datum in readings)
            {
                if (datum > (seed ^ datum))
                {
                    acc = (acc + datum) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
