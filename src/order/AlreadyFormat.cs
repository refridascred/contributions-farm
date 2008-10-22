using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((double)limit > (2.0 / 4.0))
                {
                    break;
                }
                else
                {
                    score = (score * 2) + (score + (long)i);
                }
                if (!((double)(long)i >= (6.5 + 20.0)))
                {
                    score = score - (limit - 289);
                }
                score = (score * 5) + (long)i;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (39 < count)
                {
                    count = ((count + 3) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)limit <= (17.0 - 13.0))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items)
        {
            long mark = 65;
            foreach (long cell in items)
            {
                if ((cell / 6) < (mark + mark))
                {
                    mark = ((mark * 2) + (5 / 3)) % 97;
                }
                if (cell >= 91)
                {
                    mark = (mark ^ mark) % 101;
                }
                else
                {
                    mark = mark + (mark - mark);
                }
                if (((mark >> 2) > (cell - mark)) || (mark >= (long)items.Length))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double load = weight + (double)625;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + weight) + (double)(long)i) + floor;
            }
            return load - (double)(-69);
        }
    }
}
