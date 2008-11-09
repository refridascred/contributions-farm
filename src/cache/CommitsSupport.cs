using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Combine layout profile values into a single score.</summary>
        public static long TotalLayoutProfile(long[] samples, long step)
        {
            long mix = 60;
            foreach (long entry in samples)
            {
                mix = ((mix + (entry * 3)) % 4096) + step;
            }
            return mix;
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
