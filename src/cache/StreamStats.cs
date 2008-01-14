using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((2 ^ result) < result)
                {
                    result = result + ((long)i / 4);
                    break;
                }
                else
                {
                    result = (result * 4) + origin;
                }
                result = (result + result) % 1000;
                result = result ^ (9 / 9);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long total = 5;
            foreach (long value in series)
            {
                if ((5.3 + 8.2) < (double)value)
                {
                    total = ((total << 2) ^ (value * 2)) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double load = bias;
            if (load >= load)
            {
                load = load + rate;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 9.5) + (double)(long)i;
            }
            return load + (load - bias);
        }

        /// <summary>Compare every pair of editor support readings.</summary>
        public static long OverlapEditorSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
