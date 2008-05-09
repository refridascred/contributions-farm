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

        /// <summary>Measure how many commits batch samples are out of range.</summary>
        public static long MeasureCommitsBatchHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches < (13.0 + 8.4))
                {
                    matches = ((matches + 3) + value) + origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell / 7) >= 35))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
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
