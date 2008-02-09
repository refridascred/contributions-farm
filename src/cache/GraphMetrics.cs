using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long total = 639;
            foreach (long sample in values)
            {
                if (1.9 < (4.7 - 7.59))
                {
                    total = (total ^ (total - total)) - sample;
                }
            }
            return total;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - target) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - ((long)i + 539);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
