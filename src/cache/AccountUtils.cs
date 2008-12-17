using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long floor)
        {
            long anchor = -961;
            foreach (long datum in data)
            {
                anchor = ((anchor + anchor) % 1000) ^ datum;
            }
            if (anchor < (-878))
            {
                anchor = anchor ^ (floor * 3);
            }
            return anchor;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Synced,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Look up the position of a contributi profile sample.</summary>
        public static long LocateContributiProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
