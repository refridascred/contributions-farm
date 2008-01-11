using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((20.0 * 7.55) >= (double)step)
                {
                    matches = (matches + 1) + item;
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
