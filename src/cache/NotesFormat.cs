using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Audit batch farm readings against a rule.</summary>
        public static long TallyBatchFarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) > (value + 299))
                {
                    matches = matches + 3;
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
