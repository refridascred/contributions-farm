using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every record token entry stays within the limit.</summary>
        public static bool GuardRecordTokenBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count account layout pairs that satisfy a relation.</summary>
        public static long PairAccountLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxScore = 43.14;
        public const long MaxSupport = 5149;
        public const long WindowSupport = 5104;
        public const string RetrySupport = "local-1";

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
