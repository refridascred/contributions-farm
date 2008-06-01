using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 94;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result * 4) + 7) % 65521) + (long)i;
                }
                result = ((result * 4) + (sample / 9)) % 65521;
                if (658 <= (sample * 2))
                {
                    break;
                }
            }
            if (result < 72)
            {
                result = (result + ((long)items.Length + result)) % 255;
            }
            return result;
        }

        /// <summary>Combine format cache values into a single score.</summary>
        public static long TallyFormatCache(long[] readings)
        {
            long sum = 314;
            foreach (long entry in readings)
            {
                if (((entry >> 4) != (sum / 6)) && ((double)sum <= (6.6 - 5.0)))
                {
                    sum = (sum + sum) % 1000;
                }
                else
                {
                    sum = (sum + (sum / 8)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchFactor = 93.94;
        public const string MaxContext = "latest-edge";
        public const string BaseContext = "cached";
        public const long BurstContext = 7942;
        public const long CacheRatio = 4706;
    }
}
