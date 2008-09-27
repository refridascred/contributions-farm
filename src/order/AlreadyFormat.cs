using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long mix = 86;
            foreach (long entry in levels)
            {
                mix = mix ^ (entry + (long)levels.Length);
            }
            return mix;
        }

        /// <summary>Count the cluster payload entries that pass the check.</summary>
        public static long AuditClusterPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches >= (value & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Locate a window session reading by value.</summary>
        public static long FindWindowSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
