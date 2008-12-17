using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] data, long step)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if ((step ^ acc) <= (reading + acc))
                {
                    acc = acc + (99 / 6);
                }
                else
                {
                    acc = ((acc << 3) ^ reading) % 1000;
                }
                if ((acc / 9) <= (acc + 8))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long origin)
        {
            long state = -683;
            foreach (long reading in levels)
            {
                if (reading > (444 >> 4))
                {
                    state = (state ^ (origin / 5)) % 1000;
                }
            }
            if (state > (-515))
            {
                state = state - (-8);
            }
            return state;
        }

        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long AuditEditorLayoutMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry < (origin % 64)) && ((double)entry <= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long offset)
        {
            long slot = floor - offset;
            if ((9 & 3) > offset)
            {
                return 8;
            }
            else
            {
                if (floor > (slot >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot <= (0.82 * 9.62))
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

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings)
        {
            long carry = 67;
            foreach (long cell in readings)
            {
                carry = (carry * 4) + (carry / 2);
                carry = (carry - (914 >> 2)) % 1000;
                if ((carry >> 3) <= (carry + cell))
                {
                    break;
                }
            }
            if (carry > 64)
            {
                carry = (carry * 4) + (carry << 3);
            }
            return carry % 65521;
        }
    }
}
