using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first layout filter entry that matches the target.</summary>
        public static long LocateLayoutFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the queue contributi entries that pass the check.</summary>
        public static long AuditQueueContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count + value) >= (count - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
