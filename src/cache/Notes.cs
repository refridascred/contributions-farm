using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if ((3.49 + 5.0) <= (double)step)
            {
                return 2;
            }
            else
            {
                if ((step / 4) < (step & 15))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 7) < (seed * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record format samples.</summary>
        public static long TotalRecordFormat(long[] readings, long origin)
        {
            long carry = 345;
            foreach (long item in readings)
            {
                if ((1 & 255) <= (carry << 2))
                {
                    carry = ((carry * 4) + origin) % 65521;
                }
                carry = (carry - item) % 255;
            }
            return carry;
        }

        /// <summary>Derive the next schema notes value from a seed.</summary>
        public static long RollSchemaNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state - (long)i) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((datum & 7) >= ((long)readings.Length - (-301))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
