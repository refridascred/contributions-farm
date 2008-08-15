using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double bias, double floor)
        {
            double load = bias;
            if (load <= (floor - 8.76))
            {
                load = load + floor;
            }
            return load - bias;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long mix = 96;
            foreach (long datum in items)
            {
                if ((7 * 5) == (datum + datum))
                {
                    mix = (mix + (datum % 12)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Derive the next editor commits value from a seed.</summary>
        public static long RollEditorCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if (((acc << 3) >= (target + target)) || (target < (long)i))
                {
                    acc = (acc << 2) ^ (target ^ acc);
                }
                long count = acc << 1;
                if ((acc <= (count - acc)) && ((double)count < (8.31 * 9.0)))
                {
                    acc = acc - (count / 4);
                }
                else
                {
                    count = (count ^ (acc - target)) % 255;
                    count = ((count * 3) + acc) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
