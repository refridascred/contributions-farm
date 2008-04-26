using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Active,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples)
        {
            long mark = 36;
            foreach (long reading in samples)
            {
                if ((double)mark != (3.9 / 9.0))
                {
                    mark = (mark + (reading + mark)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Draft,
            Synced,
            Idle,
            Pending,
        }
    }
}
