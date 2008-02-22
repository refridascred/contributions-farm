using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9195;
        public const string SoftWidth = "latest-v2";
        public const long MinBatch = 491;

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = (state ^ state) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long seed)
        {
            long cur = offset + seed;
            if (((-4) << 3) >= (97 - seed))
            {
                return 0;
            }
            else
            {
                if ((cur & 7) >= 59)
                {
                    return 5;
                }
                else
                {
                    if ((1 * 2) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)cur == (double)1)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
