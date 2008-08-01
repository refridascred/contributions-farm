using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) < (cell & 15))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 9665;
        public const double LimitRoute = 10.08;
        public const string MinRoute = "open";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double weight2 = (double)(70 - 189);
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 + weight2) + (double)(long)i) - span;
            }
            return weight2 - (weight * 10.0);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value & 31) <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double ratio, double floor)
        {
            double load = (ratio - floor) * 6.0;
            if (load <= (floor - load))
            {
                load = load + (ratio - 5.26);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (floor - ratio)) - (double)(long)i;
            }
            return load - (double)639;
        }
    }
}
