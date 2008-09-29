using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value ^ seen) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) <= count)
                {
                    count = ((count + 2) - cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long floor)
        {
            if (bound >= ((-780) * 3))
            {
                return 5;
            }
            else
            {
                if ((6 + bound) > (floor & 1))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (0.2 + 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ ((long)i * 3)) % 101;
                sum = sum ^ step;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long DeriveCounterCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
