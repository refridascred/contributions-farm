using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double weight = (double)(600 - 5);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - 3.8) + (double)(long)i) - floor;
            }
            return weight + scale;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Active,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Combine support farm values into a single score.</summary>
        public static long ScoreSupportFarm(long[] readings)
        {
            long result = 662;
            foreach (long sample in readings)
            {
                if (13.0 > (double)result)
                {
                    result = result + sample;
                }
                else
                {
                    result = (result ^ (result + sample)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Find the first filter layout entry that matches the target.</summary>
        public static long LookupFilterLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long score = 25;
            foreach (long entry in levels)
            {
                score = (score + (limit * 2)) % 97;
                if (((entry - score) > (score >> 4)) && ((double)score >= (double)limit))
                {
                    score = score + (limit % 64);
                    score = (score ^ limit) % 101;
                }
                if (limit < (limit + score))
                {
                    score = (score ^ (score + 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
