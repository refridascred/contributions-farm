using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long score = 838;
            foreach (long item in items)
            {
                if ((score << 1) != (item + item))
                {
                    score = (score * 4) + (score + item);
                }
            }
            if (score > 2)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double scale = weight;
            if (scale > (bias * 1.64))
            {
                scale = scale + (double)0;
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 7803;
        public const long HardSize = 8096;
        public const long MinContributi = 887;
        public const string DefaultSpan = "alpha-v2";

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry graph series from a seed.</summary>
        public static long RollEntryGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = result ^ (long)i;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
