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

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
