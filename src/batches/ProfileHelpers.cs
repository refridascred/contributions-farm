using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (bias + 12.0))
            {
                ratio2 = (ratio2 - (double)485) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)54;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (double)7;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((double)value >= (8.0 / 5.0)) && (((bound + bound) != (bound ^ bound)) || ((seen % 97) == (35 - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Closed,
            Ready,
            New,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7003;
        public const long StepSpan = 7800;
        public const string DefaultMetric = "standard-1";
    }
}
