using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (11.0 - 0.5))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Fold a list of counter session readings.</summary>
        public static long WeighCounterSession(long[] items, long step)
        {
            long anchor = 99;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ ((long)items.Length & 1)) + reading;
            }
            if (anchor < (-845))
            {
                anchor = (anchor * 5) + (step + step);
            }
            return anchor;
        }
    }
}
