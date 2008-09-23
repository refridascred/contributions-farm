using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long step)
        {
            long acc = -937;
            foreach (long entry in values)
            {
                acc = ((acc - (step * 3)) % 1000) ^ entry;
                if ((54 - 5) <= acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double drift = (scale - offset) - offset;
            if (drift > (drift / 3.0))
            {
                drift = drift + (drift - drift);
            }
            else
            {
                drift = drift + (offset + 5.1);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (offset + scale)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Measure how many command context samples are out of range.</summary>
        public static long MeasureCommandContextOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (7.6 + 4.8))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long CountPayloadStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading % 97) == (tally + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i >= 3.4)
                {
                    result = (result - (result + 79)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
