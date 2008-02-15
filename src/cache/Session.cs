using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 3785;
        public const long HardLayout = 7884;
        public const string StepLayout = "primary";
        public const long DefaultSize = 7683;
        public const double MinSize = 31.43;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                carry = carry - carry;
                if (carry <= reading)
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ ((long)i << 1);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor != (7.7 - 9.48))
                {
                    anchor = ((anchor * 3) + bound) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
