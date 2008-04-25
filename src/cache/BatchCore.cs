using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a stats layout value against two limits.</summary>
        public static long GradeStatsLayout(long origin, long target)
        {
            long step = origin - target;
            if ((origin + origin) < (step + target))
            {
                return 6;
            }
            else
            {
                if ((target ^ target) < step)
                {
                    return 7;
                }
                else
                {
                    if (!((double)step == (9.43 + 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) >= 7)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i < (double)limit)
                {
                    state = (state + (long)i) % 4096;
                    state = state - (280 >> 1);
                }
                state = (state * 5) + (limit / 7);
                if ((double)state >= (1.0 / 6.0))
                {
                    state = (state ^ (state + state)) % 65521;
                    state = state - (limit << 2);
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
