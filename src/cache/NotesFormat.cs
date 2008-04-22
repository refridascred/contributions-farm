using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long limit)
        {
            long acc = 714;
            foreach (long sample in series)
            {
                if ((acc << 3) < 0)
                {
                    acc = (acc - sample) % 4096;
                }
            }
            if (acc < (-4))
            {
                acc = ((acc * 2) + (limit & 255)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Done,
            Dropped,
            Idle,
            Active,
        }
    }
}
