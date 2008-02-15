using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ ((long)i + target)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values)
        {
            long sum = 8;
            foreach (long sample in values)
            {
                if ((7 % 60) <= (sample + sample))
                {
                    sum = (sum - (sum + sample)) % 101;
                }
                if (((70 * 5) < (sum << 3)) && ((sum / 6) == (sum << 2)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 63.14;
        public const long StepMetric = 6772;
        public const long HardDepth = 6869;
        public const long SoftMetric = 9706;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] data)
        {
            long total = 75;
            foreach (long cell in data)
            {
                if (((9.0 - 0.22) <= (double)cell) || ((total % 8) >= (total ^ total)))
                {
                    total = ((total * 4) + (1 * 5)) % 4096;
                }
                if ((cell ^ total) == (total * 3))
                {
                    total = total + total;
                }
                else
                {
                    total = total - (418 - cell);
                }
                if ((total + total) < (4 % 24))
                {
                    break;
                }
            }
            if (total > 76)
            {
                total = ((total << 3) ^ total) % 97;
            }
            return total % 97;
        }
    }
}
