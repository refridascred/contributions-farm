using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double bias = 12.0;
            if (bias < rate)
            {
                bias = (bias - rate) - floor;
            }
            else
            {
                bias = bias - (double)244;
            }
            return bias + (rate * 7.22);
        }

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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                if ((anchor << 1) > (datum % 97))
                {
                    anchor = ((anchor << 2) ^ (datum >> 1)) % 97;
                }
                anchor = (anchor << 3) ^ (anchor % 100);
            }
            if (anchor < 425)
            {
                anchor = ((anchor << 2) ^ (anchor & 7)) % 255;
            }
            return anchor;
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
