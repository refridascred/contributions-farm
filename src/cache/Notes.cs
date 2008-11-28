using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor - acc) > acc)
                {
                    acc = (acc - (floor + acc)) % 4096;
                }
                if (((double)floor <= (12.0 + 1.86)) || ((6.12 / 5.0) != (double)floor))
                {
                    acc = acc + (acc - acc);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long step)
        {
            long anchor = 87;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor << 2) ^ (step ^ datum)) % 65521) + (long)i;
                    anchor = ((anchor * 3) + (step << 3)) % 4096;
                }
                anchor = (anchor ^ (datum + datum)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Draft,
            Queued,
            Pending,
            Locked,
        }
    }
}
