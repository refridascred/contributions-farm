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

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Active,
            Paused,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data, long target)
        {
            long score = 683;
            foreach (long value in data)
            {
                score = (score * 4) + 7;
                if (!((value - value) < (target % 3)))
                {
                    score = (score ^ (1 + target)) % 255;
                }
                else
                {
                    score = (score - score) % 1000;
                }
                if ((value + value) <= (target / 3))
                {
                    break;
                }
            }
            return score % 65521;
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
