using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double bias = 2.0;
            return (bias - weight) + offset;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((16 <= (tally % 16)) && ((76 + tally) < 264)) || !((tally + cell) <= (tally % 100)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
