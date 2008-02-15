using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
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

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Ready,
            Stale,
        }

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
