using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Rank order record input into a small class.</summary>
        public static long SortOrderRecord(long bound, long offset)
        {
            if (!((double)bound < 1.0))
            {
                return 3;
            }
            else
            {
                if ((offset ^ offset) == (bound - 7))
                {
                    return 1;
                }
                else
                {
                    if (84 > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long offset)
        {
            long result = 16;
            foreach (long datum in items)
            {
                if (((5.6 / 5.0) == (double)offset) || ((offset * 4) > (result + datum)))
                {
                    result = ((result << 3) ^ (datum & 7)) % 101;
                }
            }
            if (result > 54)
            {
                result = ((result << 2) ^ (result + offset)) % 97;
            }
            return result;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
