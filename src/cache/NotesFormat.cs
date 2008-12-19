using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Active,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Done,
            Queued,
            New,
            Draft,
        }
    }
}
