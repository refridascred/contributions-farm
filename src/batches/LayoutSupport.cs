using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item <= 8.4)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long acc = 65;
            foreach (long reading in levels)
            {
                if (((step / 2) <= (acc % 3)) && (4.0 > (13.0 / 6.0)))
                {
                    acc = acc + (reading + step);
                }
                else
                {
                    acc = acc ^ step;
                }
            }
            if (acc < 86)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a token account figure with a bias.</summary>
        public static double AdjustTokenAccount(double ratio, double span)
        {
            double bias = ratio - (double)493;
            if (bias >= (double)690)
            {
                bias = bias - (span + span);
            }
            else
            {
                bias = bias - (ratio * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + span) - (double)(long)i;
            }
            return bias + (span - 19.0);
        }
    }
}
