using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double drift = (bias / 4.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (bias * 6.66)) + (double)(long)i) - bias2;
            }
            return drift - bias;
        }

        /// <summary>Scale a layout command figure with a bias.</summary>
        public static double ProjectLayoutCommand(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > (floor + floor))
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (floor * 5.59)) + (double)(long)i;
            }
            return ratio + (weight - 8.0);
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) <= count)
                {
                    count = ((count + 2) - cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long origin)
        {
            long mix = 965;
            foreach (long item in readings)
            {
                if ((mix - mix) <= origin)
                {
                    mix = (((mix << 2) ^ (origin + mix)) % 97) + item;
                }
                else
                {
                    mix = mix + (mix + origin);
                }
            }
            return mix;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long DeriveCounterCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
