using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((limit >> 5) < (diff + 30))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= 6.5)
                {
                    return 4;
                }
                else
                {
                    if (diff >= (diff - limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long offset)
        {
            if (offset >= (floor + offset))
            {
                return 4;
            }
            else
            {
                if (!(((-182) & 1) >= (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset < (floor % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((547 + offset) != (offset << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((reading % 2) <= 27) && ((reading + reading) > (35 + reading))) || ((hits + hits) == (reading + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
