using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Locate a farm editor reading by value.</summary>
        public static long LocateFarmEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
