using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 7962;
        public const string IdleCounter = "primary-edge";
        public const long StepSize = 1531;
        public const string MaxTimeout = "alpha";
        public const long LimitLevel = 1597;

        /// <summary>Blend two profile farm measurements.</summary>
        public static double ScaleProfileFarm(double rate, double floor)
        {
            double gain = rate;
            return gain + (floor / 4.0);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
