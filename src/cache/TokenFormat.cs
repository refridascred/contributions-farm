using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            New,
            Done,
            Stale,
            Active,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long origin)
        {
            long span = offset + origin;
            if ((double)span <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((span + span) > (-74))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
