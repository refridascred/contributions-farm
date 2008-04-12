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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
