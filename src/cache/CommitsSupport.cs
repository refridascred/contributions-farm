using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate buffer graph samples.</summary>
        public static long TallyBufferGraph(long[] levels, long bound)
        {
            long carry = 6;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + bound)) % 65521;
                if ((reading % 100) < reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double ratio = (double)(509 & 63);
            if (ratio <= ratio)
            {
                ratio = (ratio + (scale / 5.0)) - offset;
            }
            return ratio - scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepBudget = "local-1";
        public const double LimitGithubfarm = 23.21;
        public const long WindowGithubfarm = 5456;
        public const string HardGithubfarm = "stable-1";
        public const double BaseGithubfarm = 20.4;

        /// <summary>Digest a series of order checks entries.</summary>
        public static long DigestOrderChecks(long[] data, long target)
        {
            long score = 897;
            foreach (long datum in data)
            {
                if (((double)datum <= (9.98 * 8.66)) && ((datum << 3) != (datum >> 3)))
                {
                    score = ((score << 3) ^ (score + datum)) % 255;
                }
                else
                {
                    score = score + (datum * 2);
                }
                if ((target + score) > (datum - score))
                {
                    score = score ^ (datum + target);
                }
            }
            return score;
        }

        /// <summary>Derive the next support notes value from a seed.</summary>
        public static long StepSupportNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (29 * 3)) % 1000;
                if (((long)i != (285 - target)) && (((long)i + state) >= target))
                {
                    state = ((state * 2) + 6) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
