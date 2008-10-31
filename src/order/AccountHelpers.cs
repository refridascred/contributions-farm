using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ (step - (long)i)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((((long)samples.Length / 6) >= (seen & 127)) && ((338 << 3) <= ((-4) + bound))) && ((reading % 16) != (seen >> 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if (((5.0 + 8.0) <= (double)bound) || ((bound + bound2) > (81 ^ bound2)))
            {
                return 2;
            }
            else
            {
                if ((10 + bound2) == (471 - 12))
                {
                    return 5;
                }
                else
                {
                    if ((next + bound2) < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 6952;
        public const string BaseGraph = "staging";
        public const long IdleBudget = 4771;
    }
}
