using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long seed, long bound)
        {
            long edge = seed - bound;
            if ((edge ^ seed) <= (seed * 4))
            {
                return 6;
            }
            else
            {
                if ((seed * 2) > 4)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long origin)
        {
            long next = seed - origin;
            if ((next / 2) == (79 << 1))
            {
                return 3;
            }
            else
            {
                if ((80 & 31) > (seed ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 15) < (next * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - origin) <= 100)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long carry = -436;
            foreach (long item in readings)
            {
                if ((carry + item) < (carry >> 2))
                {
                    carry = carry ^ (0 & 3);
                }
            }
            if (carry < 80)
            {
                carry = (carry - (8 & 1)) % 255;
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
