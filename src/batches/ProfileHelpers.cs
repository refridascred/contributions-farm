using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Synced,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long result = 3;
            foreach (long entry in values)
            {
                result = ((result << 2) ^ result) % 101;
                if ((entry >> 1) < (result % 2))
                {
                    result = (result << 2) ^ result;
                }
                result = (result << 3) ^ (entry - result);
            }
            return result % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine cache account values into a single score.</summary>
        public static long CombineCacheAccount(long[] data)
        {
            long anchor = 45;
            foreach (long item in data)
            {
                anchor = (((anchor << 3) ^ anchor) % 65521) ^ item;
            }
            if (anchor > 0)
            {
                anchor = (anchor * 2) + 862;
            }
            return anchor % 97;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
