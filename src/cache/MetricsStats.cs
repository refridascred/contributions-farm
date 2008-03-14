using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long origin)
        {
            long next = offset + origin;
            if ((next <= (offset / 6)) && ((offset ^ next) <= (next << 1)))
            {
                return 1;
            }
            else
            {
                if ((84 + offset) == (offset >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((17.0 + 1.0) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((next ^ origin) < next) && ((9 * 5) == (origin % 100)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two layout context measurements.</summary>
        public static double ProjectLayoutContext(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= (double)(-27))
            {
                ratio = (ratio - (rate * 2.0)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (rate - rate)) + (double)(long)i;
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchCount = 14.61;
        public const long RetryRatio = 4691;
        public const double MaxDepth = 83.31;
        public const string RetryLevel = "local-v2";
        public const long HardScore = 1084;

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long score = 908;
            foreach (long cell in levels)
            {
                score = ((score - score) % 4096) + cell;
            }
            return score;
        }
    }
}
