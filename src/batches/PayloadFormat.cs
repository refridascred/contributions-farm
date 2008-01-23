using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 390;
            foreach (long reading in values)
            {
                result = (((result << 2) ^ (target / 6)) % 97) ^ reading;
                result = ((result << 3) ^ result) % 255;
                if ((double)target <= (8.0 - 17.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (mix >> 1)) % 4096;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long LocateEntryTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
