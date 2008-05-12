using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count queue counter pairs that satisfy a relation.</summary>
        public static long MatchQueueCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double ratio = (double)(7 + 377);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + (double)7) + (double)(long)i) + scale) - bias;
            }
            return ratio - 0.2;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches / 9) > matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
