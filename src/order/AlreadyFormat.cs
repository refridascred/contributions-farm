using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double floor)
        {
            double rate = weight;
            if (rate <= floor)
            {
                rate = rate + floor;
            }
            return rate + (floor + rate);
        }

        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long CountReportStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (3 > (seen >> 2))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + step) <= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
