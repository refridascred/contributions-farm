using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchInterval = 1969;
        public const long LimitGithubfarm = 1202;
        public const long MinGithubfarm = 1222;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long bound)
        {
            long total = 516;
            foreach (long sample in readings)
            {
                total = (total ^ (bound % 12)) % 97;
                if (!(((-65) + sample) > (total + (long)readings.Length)))
                {
                    break;
                }
            }
            if (total < 66)
            {
                total = total ^ (49 - total);
            }
            return total % 65521;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 382;
            foreach (long datum in data)
            {
                if ((12.0 * 7.0) >= (double)datum)
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Adjust a order format reading.</summary>
        public static double SmoothOrderFormat(double gain, double bias)
        {
            double scale = (double)5 + (double)826;
            if (scale <= (double)156)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (gain / 3.0);
        }
    }
}
