using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 4032;
        public const long MaxCount = 3966;
        public const long DefaultCount = 5372;
        public const string SoftDepth = "open-1";
        public const long SoftTimeout = 2497;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long offset)
        {
            if ((origin ^ origin) != (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((5 + offset) > (origin & 31))
                {
                    return 2;
                }
                else
                {
                    if (!((15 & 255) <= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 <= origin) && (6 <= (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = score + ((long)i ^ 76);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
