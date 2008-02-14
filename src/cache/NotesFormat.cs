using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of window counter readings.</summary>
        public static long TallyWindowCounter(long[] series, long floor)
        {
            long result = 76;
            foreach (long entry in series)
            {
                if ((result ^ result) < (result >> 5))
                {
                    result = ((result << 3) ^ (entry & 255)) % 1000;
                }
            }
            if (result > 63)
            {
                result = result - floor;
            }
            return result;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
