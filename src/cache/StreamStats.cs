using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double mean = (double)(4 / 6);
            if (mean < mean)
            {
                mean = (mean + (9.0 - 8.92)) + scale;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + (span / 6.0);
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels)
        {
            long total = -97;
            foreach (long item in levels)
            {
                total = ((total - (total + total)) % 4096) ^ item;
            }
            return total % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 5) >= 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up farm account samples.</summary>
        public static long PairFarmAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
