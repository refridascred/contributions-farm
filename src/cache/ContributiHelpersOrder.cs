using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data)
        {
            long mark = -8;
            foreach (long reading in data)
            {
                mark = mark - (long)data.Length;
                if ((-14) >= (reading & 63))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark ^ (mark & 3)) % 255;
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 2) >= 11)
                {
                    tally = ((tally + 3) + cell) - limit;
                }
            }
            return tally;
        }
    }
}
