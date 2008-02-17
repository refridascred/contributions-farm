using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double gain = bias * 15.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - bias2;
            }
            return gain - (bias / 7.0);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally <= ((-36) - tally))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm commits samples.</summary>
        public static long WeighGithubfarmCommits(long[] items)
        {
            long mix = 941;
            foreach (long datum in items)
            {
                if ((datum & 15) < (datum - datum))
                {
                    mix = ((mix * 4) + (datum >> 2)) % 1000;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix > 549)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "stable-1";
        public const string LimitFactor = "latest-v2";
        public const string LimitLayout = "latest-v2";
        public const string HardLayout = "latest";
    }
}
