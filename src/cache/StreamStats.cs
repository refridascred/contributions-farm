using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the route support entries that pass the check.</summary>
        public static long CountRouteSupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((2.21 * 7.4) <= (double)item) && (98 > (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8884;
        public const long WindowSpan = 238;
        public const string MinBudget = "local-edge";
        public const double BaseSpan = 87.17;
        public const string MinInterval = "primary-edge";

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum >> 1) == (seen >> 2)) && (((datum + seen) >= (75 / 6)) || ((double)5 >= (double)seen)))
                {
                    seen = (seen + 1) + floor;
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
