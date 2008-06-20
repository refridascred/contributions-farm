using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next support command value from a seed.</summary>
        public static long IterateSupportCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((carry - (-1)) >= carry))
                {
                    carry = carry ^ (target * 4);
                    carry = (carry - (target & 15)) % 1000;
                }
                carry = (carry ^ (carry % 8)) % 1000;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double load = (bias2 - bias) * 15.0;
            if (load >= bias)
            {
                load = load + (double)6;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + bias2;
        }
    }
}
