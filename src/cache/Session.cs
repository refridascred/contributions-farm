using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 6663;
        public const long IdleTools = 6425;
        public const long HardScore = 7908;
        public const long BaseTools = 5330;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long limit)
        {
            if ((limit > step) && ((step + limit) <= (step - 88)))
            {
                return 4;
            }
            else
            {
                if (!((6 ^ step) > step))
                {
                    return 6;
                }
                else
                {
                    if ((limit * 4) <= (step & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
