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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((-3) % 60) == (offset << 2))
                {
                    result = ((result * 2) + result) % 4096;
                    result = (result + (offset + offset)) % 65521;
                }
                else
                {
                    result = result ^ (offset / 9);
                }
                result = ((result << 2) ^ (offset ^ result)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
