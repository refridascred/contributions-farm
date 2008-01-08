using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((carry & 255) != (floor >> 4))
                {
                    carry = ((carry << 2) ^ ((long)i >> 1)) % 101;
                }
                else
                {
                    carry = (carry * 4) + 46;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "staging";
        public const long MinToken = 7938;
        public const long StepToken = 4265;
        public const string MaxLevel = "primary-1";
        public const double BatchLevel = 72.06;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long floor, long limit)
        {
            long prev = floor ^ limit;
            if (!((limit % 24) != (prev - floor)))
            {
                return 1;
            }
            else
            {
                if ((floor & 3) >= (floor - 396))
                {
                    return 4;
                }
                else
                {
                    if (!((4.4 / 7.0) > (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
