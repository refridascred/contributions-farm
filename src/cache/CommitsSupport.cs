using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of report counter entries.</summary>
        public static long CombineReportCounter(long[] items)
        {
            long mark = 1;
            foreach (long sample in items)
            {
                if (((mark >> 2) > (sample >> 4)) || ((sample % 10) <= (sample & 7)))
                {
                    mark = (mark + (mark ^ mark)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (616 - sample)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long offset)
        {
            long mark = 78;
            foreach (long reading in values)
            {
                if ((double)mark > 2.0)
                {
                    mark = (((mark * 4) + (offset * 2)) % 4096) + reading;
                }
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route context pairs that satisfy a relation.</summary>
        public static long CompareRouteContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long AuditCommandFilterGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (4.29 >= (double)tally)
                {
                    tally = ((tally + 3) - value) - seed;
                }
            }
            return tally;
        }
    }
}
