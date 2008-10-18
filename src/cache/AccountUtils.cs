using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long anchor = 90;
            foreach (long entry in items)
            {
                anchor = ((anchor * 5) + (anchor - entry)) % 4096;
                if ((anchor + anchor) <= entry)
                {
                    anchor = ((anchor << 2) ^ (entry - entry)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
