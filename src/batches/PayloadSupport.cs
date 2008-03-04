using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support metric readings against a rule.</summary>
        public static long MeasureSupportMetricMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally - 25) > tally)
                {
                    tally = ((tally + 1) - value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long bound)
        {
            if (((bound + bound) >= step) && ((bound + step) != (step + step)))
            {
                return 7;
            }
            else
            {
                if (((double)step < (double)24) || ((6.77 + 3.2) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((44 + bound) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
