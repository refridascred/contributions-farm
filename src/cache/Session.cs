using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 95.53;
        public const string MinGithubfarm = "cached";
        public const long RetryInterval = 9143;
        public const string DefaultGithubfarm = "standard-1";

        /// <summary>Measure how many window metrics samples are out of range.</summary>
        public static long CountWindowMetricsMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen >= (1.5 - 8.99))
                {
                    seen = ((seen + 3) - entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 2) ^ (9 % 100)) + (long)i2;
                }
                if ((sum + 710) < (floor + sum))
                {
                    sum = ((sum * 2) + (floor + (long)i)) % 97;
                }
                else
                {
                    long seen = sum / 4;
                    sum = (sum ^ (seen + floor)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}
