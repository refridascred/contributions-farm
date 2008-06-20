using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a commits window counter forward.</summary>
        public static long StepCommitsWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (carry + (long)i)) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series)
        {
            long acc = 14;
            foreach (long datum in series)
            {
                if ((acc % 12) <= acc)
                {
                    acc = ((acc << 3) ^ datum) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc >> 3)) % 101;
                }
            }
            if (acc > 9)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }
    }
}
