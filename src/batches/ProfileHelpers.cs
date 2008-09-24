using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine schema session values into a single score.</summary>
        public static long TotalSchemaSession(long[] levels, long step)
        {
            long acc = 755;
            foreach (long entry in levels)
            {
                if ((7 - entry) <= ((long)levels.Length << 1))
                {
                    acc = (acc << 3) ^ entry;
                }
                if ((step >= acc) || ((acc + step) <= (acc + acc)))
                {
                    acc = ((acc << 3) ^ entry) % 1000;
                }
                if ((double)step != (double)entry)
                {
                    acc = (acc + (step % 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 5138;
        public const long WindowCounter = 969;
        public const double MaxCounter = 39.31;
        public const long DefaultCounter = 2913;

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 59.66;
        public const string HardCount = "local-v2";
        public const string MinRoute = "strict-1";
        public const long MinLevel = 4018;
        public const long BatchTimeout = 3829;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
