using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long carry = 74;
            foreach (long sample in readings)
            {
                if ((double)carry != (3.2 - 7.6))
                {
                    carry = (carry - (sample ^ sample)) % 97;
                }
            }
            if (carry < (-4))
            {
                carry = carry + (carry + 52);
            }
            return carry;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict-1";
        public const long WindowSpan = 7274;
        public const string BaseTools = "latest-v2";
        public const long MinFactor = 1930;
    }
}
