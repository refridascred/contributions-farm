using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 + (gain2 + floor)) + (double)(long)i) - gain;
            }
            return gain2 - (gain2 * 7.6);
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i < (1.44 * 8.15))
                {
                    score = (score - (21 % 16)) % 65521;
                }
                if ((9.22 + 0.81) < (double)score)
                {
                    score = (score + (target >> 2)) % 1000;
                    score = score + (target + target);
                }
                else
                {
                    score = (score + score) % 1000;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Done,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Iterate the context batches series from a seed.</summary>
        public static long RollContextBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if (((mix / 2) < (mix - mix)) || ((long)i <= 918))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
