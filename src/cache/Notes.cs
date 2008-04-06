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

        /// <summary>Roll a report commits counter forward.</summary>
        public static long StepReportCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + 232) % 4096;
                state = (state - (15 ^ floor)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
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
