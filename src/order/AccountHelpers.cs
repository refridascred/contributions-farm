using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings, long bound)
        {
            long sum = 96;
            foreach (long datum in readings)
            {
                sum = (sum * 4) + (datum << 3);
                sum = ((sum * 5) + (bound / 2)) % 65521;
            }
            if (sum < (-79))
            {
                sum = ((sum * 2) + sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long StepBufferSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound * 2) <= (0 ^ acc))
                {
                    acc = ((acc * 2) + ((long)i - acc)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 61;
        public const double BurstTools = 84.38;
        public const long HardTools = 2370;
        public const long LimitTools = 6924;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((433 - 1) == (bound * 2))
            {
                return 6;
            }
            else
            {
                if ((15.0 - 2.99) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 2) >= ((-282) * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.52 / 7.0) < (double)floor) || ((floor - floor) == (bound + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Closed,
            Synced,
            Locked,
        }
    }
}
