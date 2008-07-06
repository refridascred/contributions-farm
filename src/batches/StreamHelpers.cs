using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double gain = (8.01 / 6.0) + bias;
            if (gain <= (span * 10.0))
            {
                gain = gain - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Look up the position of a report stream sample.</summary>
        public static long FindReportStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double span)
        {
            double ratio = (double)(883 + 42);
            return ((ratio - (double)8) + bias) + span;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepInterval = 38.31;
        public const string LimitSession = "legacy-v2";
        public const long WindowSession = 4957;
        public const long LimitFactor = 3619;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
