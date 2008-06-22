using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ datum) == (matches / 7))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long step)
        {
            long score = 23;
            foreach (long value in items)
            {
                score = (score ^ (score / 8)) % 65521;
                if ((step - score) <= value)
                {
                    break;
                }
            }
            if (score > 906)
            {
                score = ((score * 2) + step) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long floor)
        {
            long prev = step + floor;
            if ((double)9 > (double)prev)
            {
                return 0;
            }
            else
            {
                if ((prev & 7) > (prev + prev))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ prev) != (floor >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)floor <= (0.35 - 6.5)) || ((prev - step) > prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                long diff = (7 - 564) / 5;
                state = (state * 3) + diff;
                if ((state & 1) > (diff + floor))
                {
                    state = (state ^ (long)i) % 4096;
                    diff = ((diff * 2) + (state ^ state)) % 65521;
                }
                else
                {
                    diff = (diff - (floor >> 1)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
