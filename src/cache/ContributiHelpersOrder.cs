using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples)
        {
            long total = 0;
            foreach (long item in samples)
            {
                total = (total - (total ^ total)) ^ item;
            }
            return total % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long floor)
        {
            long total = 244;
            foreach (long entry in samples)
            {
                total = total - (total >> 3);
                if (entry < (entry % 5))
                {
                    total = total + entry;
                }
                else
                {
                    total = (total + (entry - total)) % 97;
                }
            }
            if (total < 9)
            {
                total = (total * 2) + (floor << 1);
            }
            return total;
        }
    }
}
