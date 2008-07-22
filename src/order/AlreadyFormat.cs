using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 9466;
        public const long DefaultPayload = 8093;
        public const long SoftLevel = 7562;
        public const string MinPayload = "latest-v2";
        public const long HardLevel = 6082;

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxCount = 66.36;
        public const long BatchContext = 4929;
        public const long LimitTimeout = 7082;
        public const long BurstContext = 3148;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if ((state * 5) == ((long)i ^ state))
                {
                    state = ((state << 2) ^ ((long)i + (long)i)) % 101;
                    state = state + (step + step);
                }
                if ((state % 97) == (step / 8))
                {
                    state = (state ^ (550 >> 1)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = (state * 3) + (state >> 5);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
