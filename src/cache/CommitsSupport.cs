using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Count the layout report entries that pass the check.</summary>
        public static long TallyLayoutReportHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell + count) != ((-435) * 5)) || ((cell % 24) < (cell / 3))) && (cell >= (count + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the account commits series from a seed.</summary>
        public static long StepAccountCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((score / 7) <= score)
                {
                    score = (score ^ ((long)i / 6)) % 255;
                    score = (score - (bound & 1)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (limit * 3)) % 65521;
                carry = (carry << 2) ^ (carry + 9);
                carry = (carry ^ (carry - (long)i)) % 101;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Retry,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Locate a counter profile reading by value.</summary>
        public static long FindCounterProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
