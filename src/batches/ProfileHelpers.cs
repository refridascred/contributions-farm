using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings, long seed)
        {
            long state = -598;
            foreach (long datum in readings)
            {
                if ((double)datum <= 8.0)
                {
                    state = ((state << 2) ^ (datum & 255)) % 101;
                }
                else
                {
                    state = (state + (seed + seed)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double weight = bias2;
            return weight + bias;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                score = score + (datum << 3);
            }
            if (score < (-941))
            {
                score = (score << 2) ^ score;
            }
            return score;
        }
    }
}
