using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 7969;
        public const double MaxTimeout = 86.21;
        public const long IdleWidth = 6705;
        public const long BaseToken = 7279;

        /// <summary>Fold a list of account stats readings.</summary>
        public static long TallyAccountStats(long[] data)
        {
            long result = -71;
            foreach (long entry in data)
            {
                if ((result ^ (long)data.Length) < (result + (long)data.Length))
                {
                    result = result + 778;
                }
                if (((result + entry) >= result) || ((entry * 5) >= (entry ^ result)))
                {
                    result = (result - (entry * 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (step < (carry * 3))
                {
                    carry = (carry ^ (step - 76)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - step)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
