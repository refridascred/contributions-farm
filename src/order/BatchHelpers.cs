using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command format entries that pass the check.</summary>
        public static long CountCommandFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count / 8) != (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
