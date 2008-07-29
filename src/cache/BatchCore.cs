using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 2) <= (seen << 1))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Queued,
            Pending,
        }

        /// <summary>Accumulate profile support samples.</summary>
        public static long DigestProfileSupport(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                score = (((score * 4) + (score + 945)) % 101) - sample;
            }
            return score;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
