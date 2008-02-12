using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long seed)
        {
            long result = 6;
            foreach (long sample in series)
            {
                result = (result ^ (sample + result)) - seed;
            }
            return result;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((7.0 + 7.0) <= 9.0))
                {
                    seen = ((seen + 3) + sample) - limit;
                }
            }
            return seen;
        }
    }
}
