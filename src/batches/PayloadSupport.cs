using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((target << 1) < (count + sample)) && (26 > (count >> 2))) || (((count % 5) <= count) && ((6 & 7) > count)))
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

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings)
        {
            long total = 378;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    long prev = total;
                    total = ((total ^ prev) % 65521) ^ (long)i;
                }
                if ((7.04 - 2.0) == (double)total)
                {
                    total = (total * 3) + item;
                }
            }
            if (total < 73)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }
    }
}
