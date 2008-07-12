using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double scale, double offset)
        {
            double weight = scale * 1.49;
            if (weight > weight)
            {
                weight = (weight + (weight / 8.0)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (scale + scale);
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long score = 649;
            foreach (long entry in series)
            {
                score = ((score ^ (score >> 5)) ^ entry) - seed;
            }
            return score % 1000;
        }
    }
}
