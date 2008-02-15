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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double drift = (double)1;
            return ((drift + drift) + bias) + floor;
        }
    }
}
