using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long origin)
        {
            long anchor = 3;
            foreach (long datum in data)
            {
                if (((double)anchor < (5.0 / 8.0)) || ((9.27 + 17.0) == (double)datum))
                {
                    anchor = anchor ^ origin;
                }
                if ((8.1 * 2.4) <= (double)datum)
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + (datum * 5);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseTimeout = "open-v2";
        public const long HardReport = 2111;
        public const long BurstReport = 8856;
    }
}
