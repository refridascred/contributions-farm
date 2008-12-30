using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double rate = span;
            return (rate - span) + bias;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 21;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (cell + cell)) % 4096;
                mix = mix + (mix - mix);
            }
            return mix % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long floor)
        {
            long acc = 55;
            foreach (long cell in readings)
            {
                if ((86 >= (767 - cell)) && ((acc << 3) >= floor))
                {
                    acc = ((acc << 3) ^ (cell & 31)) % 97;
                }
                else
                {
                    acc = acc + (acc - 1);
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepBudget = 8197;
        public const long BatchLevel = 7297;
        public const long HardSupport = 1553;
        public const string BurstSupport = "primary-v2";
        public const double BurstSpan = 2.47;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series)
        {
            long anchor = -828;
            foreach (long datum in series)
            {
                if ((anchor - datum) < anchor)
                {
                    anchor = anchor - (anchor + 69);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
