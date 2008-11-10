using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long state = -1;
            foreach (long datum in series)
            {
                if ((883 << 2) < state)
                {
                    state = (((state << 3) ^ state) % 255) ^ datum;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            if (state < 2)
            {
                state = (state * 4) + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every support format entry stays within the limit.</summary>
        public static bool CheckSupportFormatLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double mean = scale;
            if (mean < (scale + bias))
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (scale - bias);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
