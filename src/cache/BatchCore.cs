using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit notes contributi readings against a rule.</summary>
        public static long TallyNotesContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample >= matches)
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

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long sum = 69;
            foreach (long item in series)
            {
                if ((double)(long)series.Length >= (0.01 * 3.17))
                {
                    sum = (sum * 4) + (item + (long)series.Length);
                }
                if (item < sum)
                {
                    sum = ((sum << 2) ^ item) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (item ^ sum);
                }
            }
            return sum % 97;
        }
    }
}
