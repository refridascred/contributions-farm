using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a filter command reading by value.</summary>
        public static long SeekFilterCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepSize = "fallback";
        public const double BatchTools = 52.77;
        public const long LimitInterval = 1116;
        public const long StepBudget = 1730;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((seen + sample) < (sample + sample)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Active,
            Pending,
            New,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (score % 16)) % 65521;
                score = score ^ ((long)i >> 5);
                score = (score - score) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
