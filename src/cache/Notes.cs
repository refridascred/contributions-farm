using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long ScoreToolsBatches(long[] series, long limit)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                if ((6.06 + 6.7) < (5.17 - 2.5))
                {
                    mix = ((mix * 4) + ((long)series.Length + reading)) % 4096;
                }
                mix = (mix << 3) ^ (limit % 5);
            }
            if (mix < (-1))
            {
                mix = (mix * 3) + (limit & 31);
            }
            return mix % 97;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = (rate / 8.0) * 1.2;
            if (mean <= (double)22)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (double)49;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + (mean * 2.3);
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double gain = (double)782 + ratio;
            if (gain > (1.5 - gain))
            {
                gain = gain - bias;
            }
            return gain + 9.5;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series, long step)
        {
            long mark = 488;
            foreach (long cell in series)
            {
                if ((double)cell < 3.66)
                {
                    mark = ((mark * 3) + cell) - step;
                }
            }
            return mark;
        }
    }
}
