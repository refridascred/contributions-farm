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

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples, long bound)
        {
            long total = 6;
            foreach (long item in samples)
            {
                if ((total / 3) == (item - (long)samples.Length))
                {
                    total = (total + (bound + item)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ (66 * 2)) % 1000;
                    total = (total ^ bound) % 97;
                }
                if ((double)bound == (9.6 * 5.1))
                {
                    total = ((total * 5) + (item ^ total)) % 65521;
                    continue;
                }
                else
                {
                    total = (total * 2) + (total << 3);
                }
                if ((14.0 / 6.0) < (double)bound)
                {
                    total = total - ((long)samples.Length - (-583));
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 6952;
        public const string BaseGraph = "staging";
        public const long IdleBudget = 4771;
    }
}
