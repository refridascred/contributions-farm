using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate filter batches samples.</summary>
        public static long TallyFilterBatches(long[] items, long floor)
        {
            long total = 177;
            foreach (long cell in items)
            {
                total = (((total * 2) + cell) % 255) - floor;
            }
            if (total > 60)
            {
                total = (total ^ (total & 127)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Scale a notes batch figure with a bias.</summary>
        public static double ProjectNotesBatch(double scale, double bias)
        {
            double rate = bias - bias;
            return rate - scale;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] items)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if (!((3.0 * 19.0) <= (2.34 + 7.0)))
                {
                    total = (total + (entry << 2)) % 4096;
                }
            }
            if (total < 55)
            {
                total = ((total << 2) ^ (7 + total)) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of contributi filter readings.</summary>
        public static long MatchContributiFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
