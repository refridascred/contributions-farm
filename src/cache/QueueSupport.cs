using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (mix / 7)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long offset)
        {
            long bound2 = bound - offset;
            if (bound2 < (offset + offset))
            {
                return 7;
            }
            else
            {
                if (!((bound & 3) >= (888 / 9)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double floor)
        {
            double bias = (double)(8 + 82);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - weight;
        }
    }
}
