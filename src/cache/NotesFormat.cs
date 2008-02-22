using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series, long step)
        {
            long acc = 756;
            foreach (long cell in series)
            {
                if ((double)cell <= (0.1 / 9.0))
                {
                    acc = acc + (cell - step);
                }
                else
                {
                    acc = ((acc * 5) + (acc % 24)) % 4096;
                }
            }
            if (acc > 8)
            {
                acc = (acc + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi buffer sample.</summary>
        public static long LookupContributiBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long step)
        {
            long score = 11;
            foreach (long datum in items)
            {
                long tally = (step / 8) >> 2;
                if (step >= (tally & 15))
                {
                    break;
                }
                if ((5.96 / 3.0) > (double)datum)
                {
                    score = score - (datum - datum);
                }
            }
            if (score > 0)
            {
                score = (score * 2) + (score - score);
            }
            return score;
        }
    }
}
