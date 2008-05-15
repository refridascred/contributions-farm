using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a cluster counter counter forward.</summary>
        public static long IterateClusterCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum * 4) + origin;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long origin)
        {
            if ((14.0 + 0.4) > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((242 + step) < (step - step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the stats already series from a seed.</summary>
        public static long DeriveStatsAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark * 5) + (mark % 60);
                if (!(4.9 >= (double)(long)i))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
