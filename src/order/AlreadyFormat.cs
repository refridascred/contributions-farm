using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry report entries.</summary>
        public static long WeighEntryReport(long[] series, long seed)
        {
            long mark = 46;
            foreach (long value in series)
            {
                mark = ((mark ^ seed) % 97) + value;
                if ((9.0 + 3.9) >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double load = gain / 2.0;
            return (load + 9.6) + offset;
        }
    }
}
