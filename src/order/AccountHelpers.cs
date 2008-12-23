using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long offset)
        {
            if ((offset % 8) > (bound * 2))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) != (bound ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (!((bound % 60) > (offset << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound - offset) >= (offset - bound)) || ((offset % 7) <= 852))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long bound)
        {
            long total = -4;
            foreach (long value in items)
            {
                if (total < bound)
                {
                    total = total + (value + bound);
                }
            }
            if (total > (-559))
            {
                total = ((total << 2) ^ (total * 2)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 52.4;
        public const long HardWidth = 8062;
        public const long RetryInterval = 6357;
        public const string BaseSchema = "cached";
    }
}
