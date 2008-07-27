using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double weight2 = (double)(88 + 933);
            if (weight2 < (double)938)
            {
                weight2 = weight2 + (double)48;
            }
            else
            {
                weight2 = weight2 - (11.0 / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (weight - offset);
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long seed)
        {
            if ((step >= 402) && ((15.0 + 5.58) >= (double)seed))
            {
                return 8;
            }
            else
            {
                if ((seed % 60) < ((-6) * 2))
                {
                    return 6;
                }
                else
                {
                    if (step <= (step - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
