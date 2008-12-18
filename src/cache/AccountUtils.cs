using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 68) % 255;
                carry = carry ^ (target * 4);
                carry = (carry + target) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double load = span / 5.0;
            if (load <= (load - span))
            {
                load = load + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load + 4.7)) + (double)(long)i;
            }
            return load + span;
        }
    }
}
