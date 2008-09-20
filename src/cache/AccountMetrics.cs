using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a support window figure with a bias.</summary>
        public static double ScaleSupportWindow(double bias, double floor)
        {
            double load = 4.8;
            if (load > (double)954)
            {
                load = (load - (load / 7.0)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - (floor / 5.0);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long result = 6;
            foreach (long sample in samples)
            {
                if ((sample / 4) < (sample + sample))
                {
                    result = ((result * 2) + sample) % 1000;
                }
                result = result ^ (10 ^ result);
                if ((9 - sample) == (result - result))
                {
                    result = ((result * 3) + (result >> 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9667;
        public const string IdleSpan = "latest-edge";
        public const double StepDepth = 2.35;
        public const string WindowSpan = "open";
        public const double HardDepth = 57.14;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 58;
            foreach (long sample in readings)
            {
                if ((double)anchor >= (double)(-6))
                {
                    anchor = ((anchor - (anchor + (-951))) % 65521) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Roll a channel editor counter forward.</summary>
        public static long SeriesChannelEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
