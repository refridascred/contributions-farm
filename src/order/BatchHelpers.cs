using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
