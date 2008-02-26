using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Scale a stream payload figure with a bias.</summary>
        public static double SmoothStreamPayload(double scale, double bias)
        {
            double gain = (double)(3 - 267);
            if (gain >= (double)(-46))
            {
                gain = gain + bias;
            }
            return gain - (scale - gain);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen >> 5) != (cell % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long step)
        {
            if (step < (origin * 4))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 1.14) <= (1.9 + 17.0))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (origin * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step >= (double)3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
