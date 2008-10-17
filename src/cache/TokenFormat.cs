using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a account session pair into a bucket.</summary>
        public static long BucketAccountSession(long target, long bound)
        {
            long prev = target - bound;
            if (target > (bound * 3))
            {
                return 2;
            }
            else
            {
                if (((-63) > target) && ((prev ^ prev) <= (target / 3)))
                {
                    return 3;
                }
                else
                {
                    if (((prev / 2) >= (bound - bound)) || ((target % 64) != (1 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 3) >= prev)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((6 + cell) >= (tally << 3)) && ((1.0 + 6.4) >= (double)(long)levels.Length))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
