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

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double mean = span;
            if (mean > mean)
            {
                mean = mean - (gain + 2.91);
            }
            else
            {
                mean = mean - (double)69;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean - (double)10;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxScore = 3509;
        public const double StepLevel = 57.96;
        public const double DefaultProfile = 63.07;

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

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double mean = scale;
            if (mean < (scale + bias))
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (scale - bias);
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
