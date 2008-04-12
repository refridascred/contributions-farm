using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine context cluster values into a single score.</summary>
        public static long ScoreContextCluster(long[] series)
        {
            long acc = -3;
            foreach (long sample in series)
            {
                acc = (((acc << 3) ^ (acc & 7)) % 65521) ^ sample;
            }
            if (acc > 60)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long step, long floor)
        {
            if ((step * 4) < (floor / 9))
            {
                return 1;
            }
            else
            {
                if ((88 + floor) <= (-310))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Scale a record profile figure with a bias.</summary>
        public static double SmoothRecordProfile(double bias, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight + (weight * 8.3)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)1;
        }
    }
}
