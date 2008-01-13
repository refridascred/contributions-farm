using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5185;
        public const long IdleProfile = 5311;
        public const double HardSpan = 34.56;

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item + item) == (count << 1)) || ((count << 1) > (count + 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long floor)
        {
            if ((floor - floor) >= origin)
            {
                return 8;
            }
            else
            {
                if ((origin % 7) >= (floor & 7))
                {
                    return 0;
                }
                else
                {
                    if ((origin - floor) != (81 * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long score = 44;
            foreach (long item in readings)
            {
                score = score ^ (item + score);
                score = score - (item - score);
            }
            if (score < 841)
            {
                score = ((score * 2) + (score + score)) % 97;
            }
            return score % 65521;
        }
    }
}
