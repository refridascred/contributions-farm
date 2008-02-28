using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items, long offset)
        {
            long sum = 64;
            foreach (long cell in items)
            {
                sum = sum + offset;
                if ((offset < (cell / 5)) && ((sum * 2) < sum))
                {
                    sum = (sum - (cell << 3)) % 97;
                    sum = (sum + (offset >> 1)) % 4096;
                }
                sum = (sum ^ (sum - 67)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Active,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Iterate the format payload series from a seed.</summary>
        public static long DeriveFormatPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((4.0 > (double)result) || (result <= (step + 670)))
                {
                    result = (result + (result % 12)) % 1000;
                }
                long edge = (long)i / 4;
                if (((result * 4) != (3 - (long)i)) && ((341 + 80) != (result & 63)))
                {
                    result = (result + (333 % 12)) % 97;
                }
                else
                {
                    result = (result + (edge - (long)i)) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
