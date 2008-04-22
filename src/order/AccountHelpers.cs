using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry format samples.</summary>
        public static long PairEntryFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] series)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if (((double)reading == (double)mix) && ((mix / 2) > mix))
                {
                    mix = mix + 85;
                }
                else
                {
                    mix = ((mix * 4) + (reading / 8)) % 101;
                }
                if (7.3 >= (double)reading)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1040;
        public const double DefaultGithubfarm = 93.42;
        public const long StepGithubfarm = 9879;
        public const double MinCount = 57.59;
        public const long BurstDepth = 2245;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "latest-edge";
        public const long StepTimeout = 5406;
        public const double WindowEntry = 76.5;

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double rate = span + span;
            if (rate > ratio)
            {
                rate = rate + span;
            }
            return rate + ratio;
        }
    }
}
