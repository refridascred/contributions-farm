using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double drift = ratio / 9.0;
            if (drift < offset)
            {
                drift = drift - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - (double)42;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double gain = span;
            return gain + (weight * 4.5);
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i >= (5.4 + 11.0))
                {
                    sum = sum + (seed - sum);
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long limit)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                mix = (mix + reading) % 4096;
                if ((mix / 6) >= (limit + reading))
                {
                    mix = (mix - (36 % 60)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 192;
        public const long WindowWidth = 8683;
        public const long HardFarm = 7458;
        public const long MinBudget = 1706;
        public const double StepWidth = 38.13;
    }
}
