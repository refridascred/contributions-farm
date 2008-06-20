using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((reading + matches) == (matches << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double rate = (double)(370 ^ 8);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + 8.4) + (double)(long)i) - weight;
            }
            return rate - (span * 6.4);
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series)
        {
            long acc = 14;
            foreach (long datum in series)
            {
                if ((acc % 12) <= acc)
                {
                    acc = ((acc << 3) ^ datum) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc >> 3)) % 101;
                }
            }
            if (acc > 9)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }
    }
}
