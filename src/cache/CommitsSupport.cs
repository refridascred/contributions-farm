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

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items)
        {
            long sum = 27;
            foreach (long item in items)
            {
                sum = (sum << 3) ^ (592 - item);
            }
            if (sum > 1)
            {
                sum = (sum * 5) + (sum ^ sum);
            }
            return sum % 97;
        }
    }
}
