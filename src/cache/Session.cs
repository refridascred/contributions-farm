using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((18.0 + 9.3) >= (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the entry schema entries that pass the check.</summary>
        public static long CountEntrySchemaGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)398)
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
