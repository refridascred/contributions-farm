using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long carry = 627;
            foreach (long value in data)
            {
                if (((value + carry) < carry) && (1 < (step + value)))
                {
                    carry = carry ^ (carry + 79);
                }
            }
            if (carry < 65)
            {
                carry = ((carry * 2) + (0 << 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryInterval = 786;
        public const long IdleTools = 6393;
        public const long MaxTools = 2484;
        public const long MinTools = 9547;
    }
}
