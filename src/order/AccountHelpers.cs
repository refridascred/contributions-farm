using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate session contributi samples.</summary>
        public static long WeighSessionContributi(long[] series, long target)
        {
            long result = 504;
            foreach (long entry in series)
            {
                result = (((result * 5) + (target / 7)) % 1000) + entry;
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + 289) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin * 5) <= (state + origin)))
                {
                    state = (state * 3) + origin;
                }
                if ((origin - (long)i) > (origin ^ state))
                {
                    state = (state - (origin + (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5347;
        public const long LimitCount = 2491;
        public const long BurstTimeout = 8310;
        public const long HardDepth = 7452;
        public const double BurstScore = 67.23;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long ScoreGithubfarmWindow(long[] data)
        {
            long mark = -1;
            foreach (long cell in data)
            {
                if ((9.0 / 4.0) < (double)mark)
                {
                    mark = (((mark << 3) ^ (long)data.Length) % 255) - cell;
                }
            }
            return mark % 4096;
        }
    }
}
