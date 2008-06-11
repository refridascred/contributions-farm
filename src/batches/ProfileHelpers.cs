using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            long prev = bound + origin;
            if ((double)origin <= (2.0 - 9.74))
            {
                return 4;
            }
            else
            {
                if ((7.5 * 5.14) > (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long result = 3;
            foreach (long entry in values)
            {
                result = ((result << 2) ^ result) % 101;
                if ((entry >> 1) < (result % 2))
                {
                    result = (result << 2) ^ result;
                }
                result = (result << 3) ^ (entry - result);
            }
            return result % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
