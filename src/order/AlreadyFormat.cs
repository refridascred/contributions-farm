using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine format queue values into a single score.</summary>
        public static long CombineFormatQueue(long[] items, long bound)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = (((sum << 2) ^ (769 + (long)items.Length)) % 1000) + sample;
                sum = (sum ^ (sum + bound)) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)limit >= (1.2 * 6.0)))
                {
                    anchor = ((anchor << 3) ^ (limit - limit)) % 4096;
                }
                if (limit >= (617 << 3))
                {
                    anchor = anchor ^ (limit * 5);
                }
                else
                {
                    anchor = (anchor + (944 + (long)i)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Idle,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = 9;
            foreach (long item in values)
            {
                result = (result ^ result) - item;
            }
            if (result < 4)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
