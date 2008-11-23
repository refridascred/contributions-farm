using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mark = -51;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = mark - (long)i;
                }
                if ((mark & 255) == (item + mark))
                {
                    mark = mark + (item + 102);
                }
                if (((item + mark) >= (mark - 5)) || ((item + item) <= (item / 4)))
                {
                    break;
                }
            }
            if (mark > 20)
            {
                mark = ((mark * 2) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Ready,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= 3.1)
            {
                ratio = (ratio - (double)25) - span;
            }
            return ratio - (ratio / 7.0);
        }
    }
}
