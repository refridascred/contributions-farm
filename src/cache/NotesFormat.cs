using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report filter values into a single score.</summary>
        public static long WeighReportFilter(long[] samples)
        {
            long acc = 379;
            foreach (long sample in samples)
            {
                if ((acc - 840) >= acc)
                {
                    acc = (acc - (acc / 5)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + sample) % 4096;
                }
            }
            if (acc < 51)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
