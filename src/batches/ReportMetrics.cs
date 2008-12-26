using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload contributi readings.</summary>
        public static long MatchPayloadContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format stats entries.</summary>
        public static long DigestFormatStats(long[] samples)
        {
            long mark = 75;
            foreach (long entry in samples)
            {
                mark = ((mark << 3) ^ entry) % 255;
            }
            if (mark < 1)
            {
                mark = (mark * 3) + (mark + 3);
            }
            return mark % 97;
        }
    }
}
