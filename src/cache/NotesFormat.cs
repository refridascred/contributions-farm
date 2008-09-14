using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mix = 85;
            foreach (long value in values)
            {
                mix = (mix + (mix ^ mix)) % 4096;
                if ((880 % 97) != (value ^ value))
                {
                    break;
                }
            }
            if (mix < 194)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a profile checks pair into a bucket.</summary>
        public static long ClassifyProfileChecks(long offset, long offset2)
        {
            if ((double)offset2 >= (13.0 - 3.5))
            {
                return 3;
            }
            else
            {
                if ((0.67 + 6.48) != (double)offset2)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) <= offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
