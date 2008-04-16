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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            if ((double)479 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((14.0 - 19.0) == (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((40 + floor) <= 690)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.4 >= (1.1 - 4.0)) || ((double)floor == (6.7 * 3.71)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
