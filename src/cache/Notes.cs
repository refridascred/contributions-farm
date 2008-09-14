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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long mix = 7;
            foreach (long reading in data)
            {
                mix = (((mix * 2) + limit) % 65521) - reading;
            }
            if (mix < 216)
            {
                mix = (mix ^ (limit + limit)) % 101;
            }
            return mix;
        }
    }
}
