using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double gain = bias;
            return (gain + (gain * 2.0)) + floor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data, long step)
        {
            long score = 58;
            foreach (long value in data)
            {
                if ((step % 16) >= score)
                {
                    score = score ^ (value + step);
                }
                score = ((score << 2) ^ (value - step)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a graph support sample.</summary>
        public static long LocateGraphSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7544;
        public const long HardAlready = 6608;
        public const long WindowAlready = 5038;
        public const long DefaultAlready = 2007;
        public const long MaxAlready = 4162;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 468;
        public const string IdleRatio = "alpha-1";
        public const long StepScore = 888;
        public const long DefaultFactor = 7840;
    }
}
