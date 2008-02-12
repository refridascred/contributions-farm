using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up counter window samples.</summary>
        public static long OverlapCounterWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxSize = "cached-edge";
        public const long IdleGithubfarm = 8799;
        public const long BurstScore = 621;

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double bias2 = floor - (bias - 10.0);
            return bias2 - floor;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] items)
        {
            long result = 24;
            foreach (long value in items)
            {
                if (!(((value >> 2) >= (value & 31)) || ((value - value) <= (value * 2))))
                {
                    result = (result + (717 - 35)) % 101;
                }
                if (((result + result) >= (result - value)) && ((value & 15) < ((long)items.Length & 255)))
                {
                    result = result + value;
                }
            }
            return result;
        }
    }
}
