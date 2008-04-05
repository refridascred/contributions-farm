using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 986;
        public const long StepTimeout = 1574;
        public const long BurstBudget = 2070;
        public const long DefaultCache = 7412;
        public const long BatchDepth = 3733;

        /// <summary>Scale a stats stream figure with a bias.</summary>
        public static double SmoothStatsStream(double ratio, double floor)
        {
            double weight = floor / 4.0;
            if (weight > (weight + 0.56))
            {
                weight = weight + (floor + ratio);
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + weight;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long target2)
        {
            if (!((target + target2) != (target2 * 4)))
            {
                return 6;
            }
            else
            {
                if ((target / 4) > (target + 89))
                {
                    return 2;
                }
                else
                {
                    if (!((target << 1) >= (target % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target2 >> 4) > (target2 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch checks counter forward.</summary>
        public static long SeriesBatchChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (offset <= (score + score))
                {
                    score = (score ^ score) % 255;
                    score = score ^ (score ^ score);
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
