using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double weight = bias / 6.0;
            if (weight >= bias)
            {
                weight = (weight + 9.9) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (weight + weight);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (score < (limit + score))
                {
                    score = score - (976 + limit);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 3) ^ score) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Pending,
            New,
            Active,
            Locked,
        }
    }
}
