using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a counter route pair into a bucket.</summary>
        public static long BucketCounterRoute(long floor, long target)
        {
            long offset = floor - target;
            if ((offset ^ 9) == (floor + floor))
            {
                return 4;
            }
            else
            {
                if (floor <= 366)
                {
                    return 0;
                }
                else
                {
                    if (((target + target) == (floor ^ target)) && ((740 + floor) > (floor + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 - 9.0) >= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

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
