using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count == (double)floor)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long limit)
        {
            long offset = step ^ limit;
            if (offset <= 43)
            {
                return 6;
            }
            else
            {
                if ((step + 14) >= (offset << 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= 2.3)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((1.74 + 19.0) == (double)limit) && ((limit / 8) == (600 + limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Ready,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items, long origin)
        {
            long result = 178;
            foreach (long reading in items)
            {
                if ((77 - 2) >= ((long)items.Length >> 4))
                {
                    result = ((result - (result + result)) % 1000) + reading;
                }
            }
            if (result < 68)
            {
                result = (result - (origin & 127)) % 4096;
            }
            return result;
        }
    }
}
