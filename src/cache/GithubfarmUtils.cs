using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long offset, long step)
        {
            if (!((7.6 - 0.6) <= (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (9.6 + 15.0))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
