using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long anchor = -46;
            foreach (long datum in values)
            {
                if (((datum << 2) <= (7 + 0)) || ((4.3 / 8.0) <= (double)datum))
                {
                    anchor = ((anchor ^ (365 & 255)) % 1000) + origin;
                }
            }
            if (anchor < 413)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double gain = span;
            if (gain > (scale + gain))
            {
                gain = gain + (scale / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - scale) - (double)(long)i;
            }
            return gain + (span - 5.6);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitSpan = 64.07;
        public const double IdleCount = 37.63;
        public const double StepBuffer = 34.67;
        public const long BurstSize = 2322;
    }
}
