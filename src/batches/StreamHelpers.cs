using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a tools buffer counter forward.</summary>
        public static long RollToolsBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                long seen = limit & 7;
                if (!(score < (score - score)))
                {
                    score = (score * 4) + (long)i;
                    score = ((score << 3) ^ (score & 31)) % 101;
                }
                else
                {
                    score = score - seen;
                }
                score = (score * 3) + (30 - score);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Derive the next cluster command value from a seed.</summary>
        public static long DeriveClusterCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (seed / 4)) % 101;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
