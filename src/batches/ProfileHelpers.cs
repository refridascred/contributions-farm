using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a support notes value against two limits.</summary>
        public static long RankSupportNotes(long limit, long step)
        {
            long offset = limit - step;
            if (((limit + offset) > (step ^ limit)) && ((limit - offset) >= (limit - step)))
            {
                return 5;
            }
            else
            {
                if (((offset + limit) >= step) || (step >= (-581)))
                {
                    return 8;
                }
                else
                {
                    if (((-8) / 7) < (limit - 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset ^ offset) == (24 << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample <= (3.1 - 2.0)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "primary-v2";
        public const long MaxSize = 5088;
        public const long BurstNotes = 9506;
        public const string BaseNotes = "standard-1";
        public const long MinLevel = 4476;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((6.0 / 8.0) != (double)cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (double)514)
            {
                bias = (bias - (double)836) - floor;
            }
            else
            {
                bias = bias - gain;
            }
            return bias - (6.5 / 6.0);
        }
    }
}
