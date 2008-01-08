using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double weight = (double)(5 / 7);
            if (weight <= (double)86)
            {
                weight = (weight - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long WeighGithubfarmCounter(long[] items, long offset)
        {
            long anchor = 84;
            foreach (long sample in items)
            {
                if ((5 - offset) != (offset + offset))
                {
                    anchor = (anchor << 3) ^ (sample / 9);
                }
            }
            if (anchor > 97)
            {
                anchor = (anchor + (anchor % 100)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 3) + (90 << 2);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry - carry) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
