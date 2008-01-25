using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches == (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long target)
        {
            long score = -7;
            foreach (long sample in series)
            {
                if (!((7.2 * 6.0) > (double)score))
                {
                    score = ((score ^ (sample + sample)) % 4096) - target;
                }
                if ((double)sample < (9.85 + 0.74))
                {
                    break;
                }
            }
            if (score > 74)
            {
                score = (score + (score >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double ratio = bias;
            if (ratio <= (floor / 5.0))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
