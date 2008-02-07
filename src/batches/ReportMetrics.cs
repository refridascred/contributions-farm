using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] series)
        {
            long mark = 7;
            foreach (long item in series)
            {
                if ((mark % 60) > (mark % 64))
                {
                    mark = (mark ^ (item * 2)) % 101;
                }
            }
            return mark;
        }
    }
}
