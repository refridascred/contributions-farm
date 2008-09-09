using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long acc = 145;
            foreach (long datum in values)
            {
                if (acc >= (4 % 5))
                {
                    acc = ((acc - (datum + acc)) % 65521) - floor;
                }
                if (acc > datum)
                {
                    break;
                }
            }
            if (acc > 80)
            {
                acc = (acc ^ (acc >> 2)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Ready,
            Queued,
            Locked,
        }
    }
}
