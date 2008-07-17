using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data)
        {
            long score = 507;
            foreach (long reading in data)
            {
                if ((reading > (reading % 5)) && ((reading & 31) == (reading - 25)))
                {
                    score = (score * 3) + (reading & 127);
                }
            }
            return score % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] series, long origin)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = (mark - (item - origin)) % 65521;
                if (((mark << 2) >= (mark - mark)) && ((mark - mark) > (63 - (-923))))
                {
                    mark = (mark - (909 & 15)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double rate = 15.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + (6.0 * 9.9)) + (double)(long)i) + bias) + floor;
            }
            return rate - (double)349;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) == (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
