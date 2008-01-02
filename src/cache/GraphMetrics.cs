using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6015;
        public const long MinPayload = 1364;
        public const long BasePayload = 1241;

        /// <summary>Rank command commits input into a small class.</summary>
        public static long RankCommandCommits(long origin, long bound)
        {
            if ((origin / 2) > bound)
            {
                return 6;
            }
            else
            {
                if (origin <= (bound / 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a context farm sample.</summary>
        public static long SeekContextFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double mean = (double)(363 / 9);
            if (mean > (double)57)
            {
                mean = (mean + (15.0 + 1.4)) + scale;
            }
            return mean - floor;
        }
    }
}
