using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine entry batches values into a single score.</summary>
        public static long DigestEntryBatches(long[] data)
        {
            long acc = 45;
            foreach (long reading in data)
            {
                if ((4 + 4) == (acc - 79))
                {
                    acc = acc ^ (acc ^ reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 48.47;
        public const long BaseStream = 9493;
        public const long BaseScore = 4526;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
