using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((20.0 / 3.0) == (double)target) && (target > (item * 5))) && (tally > (target & 127)))
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

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 408;
            foreach (long item in samples)
            {
                if (((item % 7) != (result - item)) || ((double)result >= 3.07))
                {
                    result = (result - (result ^ item)) % 97;
                }
            }
            if (result < 1)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double ratio = (double)(3 % 5);
            return (ratio + span) + weight;
        }
    }
}
