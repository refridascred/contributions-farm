using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data, long floor)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                acc = (acc + (636 & 31)) - floor;
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc << 3) ^ (reading / 4)) ^ (long)i;
                }
                acc = (acc * 3) + (reading >> 2);
            }
            return acc;
        }

        /// <summary>Blend two profile commits measurements.</summary>
        public static double ScaleProfileCommits(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias - floor))
            {
                bias = bias + (weight - floor);
            }
            return bias + (double)432;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i >> 5) < 1))
                {
                    continue;
                }
                else
                {
                    score = (score * 4) + (score + 8);
                    score = (score - (origin / 3)) % 97;
                }
                score = ((score << 3) ^ (score * 4)) % 255;
                if ((score + score) <= ((long)i >> 2))
                {
                    score = ((score << 3) ^ (score >> 3)) % 4096;
                    score = score + 65;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
