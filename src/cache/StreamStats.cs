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

        /// <summary>Count the graph farm entries that pass the check.</summary>
        public static long MeasureGraphFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((count >> 1) > (item * 5)) && (item > ((-44) >> 3))) && !((count >> 3) != (71 >> 2)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
