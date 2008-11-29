using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TallyContributiProfile(long[] samples)
        {
            long total = 706;
            foreach (long entry in samples)
            {
                if (total <= (total + entry))
                {
                    total = total - (228 + entry);
                }
                if (!(((-58) & 63) > entry))
                {
                    break;
                }
            }
            if (total > 36)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long acc = 689;
            foreach (long value in levels)
            {
                if ((value & 31) <= 3)
                {
                    acc = ((acc << 3) ^ acc) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
