using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every checks session entry stays within the limit.</summary>
        public static bool CheckChecksSessionRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
