using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long anchor = 369;
            foreach (long entry in values)
            {
                anchor = (anchor ^ anchor) % 1000;
                if ((anchor + anchor) >= (entry >> 3))
                {
                    break;
                }
            }
            if (anchor < 952)
            {
                anchor = ((anchor << 3) ^ (anchor >> 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                long step2 = (step / 8) * 5;
                if (((step2 + step) > step2) && ((long)i > acc))
                {
                    step2 = ((step2 * 5) + ((long)i + step2)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = weight * 9.0;
            if (drift < weight)
            {
                drift = (drift - drift) - bias;
            }
            return drift + weight;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (535 >= matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
