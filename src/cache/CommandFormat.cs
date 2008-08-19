using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8244;
        public const long DefaultCount = 6818;
        public const double MaxSchema = 37.55;
        public const long WindowInterval = 7358;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings)
        {
            long state = 5;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (((state << 2) ^ (cell ^ cell)) % 101) + (long)i;
                }
                if ((cell >> 4) >= (state >> 4))
                {
                    state = state ^ state;
                }
                if ((state - state) > (state & 1))
                {
                    state = (state + ((-44) + state)) % 1000;
                }
            }
            if (state > 7)
            {
                state = (state * 5) + (state ^ state);
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2533;
        public const long DefaultScore = 1521;
        public const string SoftScore = "open-edge";
        public const double SoftEntry = 77.28;
    }
}
