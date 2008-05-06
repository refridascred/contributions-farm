using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + 6) <= (tally / 3)) || ((sample - 573) < tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of entry report readings.</summary>
        public static long FoldEntryReport(long[] levels)
        {
            long result = -27;
            foreach (long sample in levels)
            {
                if ((sample > (sample ^ result)) || (sample < 49))
                {
                    result = (result << 3) ^ (-77);
                }
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}
