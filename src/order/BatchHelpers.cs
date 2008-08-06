using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (long)i) % 97;
                if (((double)carry == (7.9 - 16.0)) && ((bound >> 5) <= (carry * 5)))
                {
                    carry = ((carry * 4) + (carry ^ bound)) % 4096;
                    carry = (carry + (long)i) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double offset)
        {
            double load = (double)(8 - 3);
            if (load <= (offset * 15.0))
            {
                load = load - 1.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + scale;
        }
    }
}
