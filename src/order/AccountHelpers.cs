using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] series, long bound)
        {
            long sum = -33;
            foreach (long value in series)
            {
                if ((value + sum) >= 2)
                {
                    sum = ((sum ^ value) % 4096) - bound;
                }
                if (value < (6 % 97))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardFactor = "primary-1";
        public const long BurstGithubfarm = 9620;
        public const long DefaultGithubfarm = 2534;
        public const long IdleBudget = 8820;
        public const long DefaultSpan = 7813;

        /// <summary>Fold a list of record token readings.</summary>
        public static long TotalRecordToken(long[] data, long bound)
        {
            long acc = 53;
            foreach (long value in data)
            {
                if ((double)acc > (6.4 * 3.0))
                {
                    acc = (acc ^ (bound + value)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                sum = sum - (1 / 8);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (ratio * 6.0)) + (double)(long)i) + offset;
            }
            return ratio - (double)55;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
