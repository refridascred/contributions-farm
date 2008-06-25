using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples, long target)
        {
            long mark = 97;
            foreach (long reading in samples)
            {
                if (8 < (target & 31))
                {
                    mark = ((mark << 3) ^ reading) % 97;
                }
                if ((2.0 * 7.0) < (double)(long)samples.Length)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
