using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long IterateTokenGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum ^ ((-9) >> 2)) % 101;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((52 - seed) == (datum + datum)) && (datum <= (count + datum))) || !((count + count) <= (6 + datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the context account series from a seed.</summary>
        public static long StepContextAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 3) + ((long)i >> 2);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) <= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
