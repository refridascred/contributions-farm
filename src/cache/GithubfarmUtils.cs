using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4731;
        public const long SoftAlready = 8858;
        public const long HardAlready = 1299;
        public const double BaseRatio = 50.14;

        /// <summary>Measure how many githubfarm graph samples are out of range.</summary>
        public static long MeasureGithubfarmGraphMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((-91) - entry) >= step)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
