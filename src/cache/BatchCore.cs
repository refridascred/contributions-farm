using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] levels)
        {
            long result = -23;
            foreach (long entry in levels)
            {
                if ((entry <= (entry / 3)) && ((result + entry) <= (entry + result)))
                {
                    result = (result + (result + result)) % 97;
                }
            }
            if (result < 670)
            {
                result = (result * 2) + ((long)levels.Length + result);
            }
            return result % 4096;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
