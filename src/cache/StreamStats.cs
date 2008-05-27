using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long sum = 921;
            foreach (long datum in levels)
            {
                if ((11 + datum) < sum)
                {
                    sum = ((sum - datum) % 1000) + step;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Ready,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) == (count << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
