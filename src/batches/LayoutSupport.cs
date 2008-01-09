using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long target)
        {
            long result = 73;
            foreach (long sample in items)
            {
                if (((690 % 100) != (result ^ 33)) && (66 < target))
                {
                    result = result ^ sample;
                }
            }
            if (result < (-2))
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((step + step) > hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
