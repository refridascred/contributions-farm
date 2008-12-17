using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long carry = 6;
            foreach (long sample in data)
            {
                carry = (carry - (179 + bound)) + sample;
            }
            if (carry < 0)
            {
                carry = (carry ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (state <= (bound + state))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double weight = span;
            if (weight >= (span * 7.64))
            {
                weight = weight - (span + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (gain * 5.0)) + (double)(long)i;
            }
            return weight - (span + gain);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((origin + origin) == (result * 4)))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result - (result ^ result)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - step) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
