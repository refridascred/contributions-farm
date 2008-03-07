using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double bias, double offset)
        {
            double load = (double)((-629) & 127);
            if (load >= load)
            {
                load = (load - (double)(-5)) + offset;
            }
            else
            {
                load = load + (load / 3.0);
            }
            return load + bias;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double rate, double floor)
        {
            double ratio = (double)0 - (2.41 / 6.0);
            if (ratio >= (ratio + floor))
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio + (double)(-57);
            }
            return ratio + rate;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc * 4) + (step + acc);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
