using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((sum + offset) == (sum << 2)))
                {
                    sum = (sum - (sum + offset)) % 255;
                }
                if (((sum ^ sum) >= (offset + sum)) && ((offset * 4) == (sum ^ offset)))
                {
                    sum = (sum ^ ((long)i ^ sum)) % 4096;
                    sum = (sum ^ (sum ^ (long)i)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate record buffer readings against a bound.</summary>
        public static bool CheckRecordBufferLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
