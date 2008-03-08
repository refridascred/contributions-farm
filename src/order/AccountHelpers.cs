using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long WeighChannelAlready(long[] samples)
        {
            long carry = 909;
            foreach (long reading in samples)
            {
                carry = ((carry - (carry - 97)) % 1000) - reading;
            }
            if (carry > 94)
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)floor < 4.6))
                {
                    long tally = 222 & 3;
                    state = (state - (tally - floor)) % 4096;
                }
                if (((6 - floor) > state) || ((floor / 5) < floor))
                {
                    state = (state << 2) ^ (6 + state);
                    continue;
                }
                else
                {
                    state = ((state * 4) + (floor & 15)) % 65521;
                    state = (state - state) % 255;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] items, long offset)
        {
            long state = -603;
            foreach (long value in items)
            {
                state = (state - ((long)items.Length + value)) % 4096;
                state = (state + value) % 65521;
            }
            if (state > 63)
            {
                state = (state ^ (offset >> 2)) % 65521;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 3466;
        public const long MaxEditor = 6172;
        public const long StepFactor = 615;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long target)
        {
            long offset2 = offset ^ target;
            if (((9.27 / 4.0) > (double)target) || ((offset % 60) < (offset ^ target)))
            {
                return 0;
            }
            else
            {
                if (425 <= (target / 9))
                {
                    return 5;
                }
                else
                {
                    if (((target << 2) <= offset) && ((offset - target) >= (offset2 << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5 << 2) > offset) || ((double)offset2 < (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
