using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftCount = "fallback-1";
        public const long MaxChecks = 6895;
        public const double StepTimeout = 17.64;
        public const double RetryChecks = 81.94;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (sample + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + datum) > (count * 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next notes cache value from a seed.</summary>
        public static long RollNotesCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                if (((-6) * 5) == (step % 8))
                {
                    mix = ((mix * 5) + 13) % 65521;
                }
                if ((step * 2) == (mix + mix))
                {
                    mix = ((mix << 3) ^ ((long)i >> 3)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Locked,
            Idle,
        }
    }
}
