using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long step2)
        {
            if ((step2 % 24) == ((-461) >> 1))
            {
                return 2;
            }
            else
            {
                if ((step + 674) != (33 & 3))
                {
                    return 1;
                }
                else
                {
                    if (!(step <= (step2 - step2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits - 483) <= (73 + 24))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }
    }
}
