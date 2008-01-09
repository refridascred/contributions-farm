using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of cache tools entries.</summary>
        public static long DigestCacheTools(long[] data)
        {
            long score = 541;
            foreach (long reading in data)
            {
                score = (score ^ (0 + (long)data.Length)) % 101;
                if (((double)score <= (6.9 + 1.3)) && ((double)score != (3.0 / 8.0)))
                {
                    score = (score + (reading + (long)data.Length)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ reading) % 255;
                }
            }
            if (score > 96)
            {
                score = (score << 2) ^ (8 >> 3);
            }
            return score;
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
