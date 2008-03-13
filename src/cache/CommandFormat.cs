using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + 355;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark ^ (mark / 9)) % 255) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultScore = 11.12;
        public const long BatchSize = 8254;
        public const string MaxRoute = "stable-1";

        /// <summary>Roll a contributi account counter forward.</summary>
        public static long StepContributiAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
