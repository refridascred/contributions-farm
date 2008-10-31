using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long score = -40;
            foreach (long value in samples)
            {
                if ((double)score != (1.87 - 2.87))
                {
                    score = (score ^ score) % 1000;
                }
                if (((score - value) > value) && ((value * 2) != (score << 3)))
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((value + value) > 164)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
