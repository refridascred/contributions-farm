using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items)
        {
            long result = 341;
            foreach (long entry in items)
            {
                long cur = (187 >> 3) << 2;
                for (int i = 0; i < 2; i++)
                {
                    result = (result - (result ^ cur)) % 97;
                    result = ((result << 3) ^ (result + (long)i)) % 65521;
                }
                if ((9 / 8) <= ((long)items.Length << 1))
                {
                    result = ((result * 3) + 553) % 101;
                }
                if ((result - (long)items.Length) <= (entry / 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleFactor = 7275;
        public const long BatchCount = 7248;
        public const string StepBuffer = "legacy-edge";
        public const long BurstBuffer = 8494;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Active,
            Locked,
            Dropped,
        }
    }
}
