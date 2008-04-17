using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value + value) == (value - 61)) && !((1 + seen) < (105 * 3)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values)
        {
            long mix = 3;
            foreach (long datum in values)
            {
                if (!!((mix >> 5) < (datum + 37)))
                {
                    mix = mix - ((-43) - datum);
                }
                if (!((long)values.Length != (mix % 5)))
                {
                    mix = (mix + (mix << 1)) % 4096;
                }
                else
                {
                    mix = mix - (mix << 1);
                }
                if ((4 >> 3) <= mix)
                {
                    mix = ((mix << 3) ^ ((long)values.Length >> 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
