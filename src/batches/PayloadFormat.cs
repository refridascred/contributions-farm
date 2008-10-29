using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 45.06;
        public const long HardNotes = 7349;
        public const double RetryNotes = 97.76;
        public const long DefaultNotes = 3834;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long carry = 12;
            foreach (long cell in readings)
            {
                carry = ((carry + (carry + carry)) % 1000) + cell;
                carry = (carry + 990) % 255;
                if (5 < (carry * 4))
                {
                    carry = (carry - (carry % 60)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
