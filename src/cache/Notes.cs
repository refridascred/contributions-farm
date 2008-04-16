using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "primary-1";
        public const long StepWidth = 6868;
        public const double WindowCount = 96.67;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Pending,
            Draft,
            New,
            Synced,
        }

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long WeighLayoutStream(long[] items, long bound)
        {
            long result = 6;
            foreach (long sample in items)
            {
                result = ((result - bound) % 4096) + sample;
            }
            return result;
        }

        /// <summary>Measure how many token layout samples are out of range.</summary>
        public static long TallyTokenLayoutHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)value == (9.8 * 10.0)) && ((seen & 63) <= seen))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
