using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long OverlapChecksContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster schema input into a small class.</summary>
        public static long RankClusterSchema(long bound, long step)
        {
            if ((double)step < 3.74)
            {
                return 3;
            }
            else
            {
                if (!(step < (step ^ bound)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches >> 4) == (value >> 4)) && ((matches - seed) > (seed / 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
