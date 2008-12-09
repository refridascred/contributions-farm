using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long ScoreFarmBuffer(long[] values)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((score + 981) < (score << 3))
                {
                    continue;
                }
                if ((score / 3) <= (cell - score))
                {
                    score = (score * 3) + ((-723) / 8);
                }
            }
            if (score > 64)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double bias = 4.5 / 7.0;
            if (bias < bias)
            {
                bias = (bias - (bias - weight)) + span;
            }
            else
            {
                bias = bias - (bias / 7.0);
            }
            return bias - (weight + weight);
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long offset)
        {
            long result = 68;
            foreach (long sample in data)
            {
                if (((result << 1) < (sample - offset)) || (sample <= 550))
                {
                    result = result + (offset << 1);
                }
                if ((9 + result) == (offset >> 2))
                {
                    result = result ^ (result / 3);
                }
                else
                {
                    result = (result - (80 - offset)) % 65521;
                }
            }
            return result;
        }
    }
}
