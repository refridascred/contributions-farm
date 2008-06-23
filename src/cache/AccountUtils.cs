using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
