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

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                if ((double)score <= (double)47)
                {
                    score = (score ^ 53) % 97;
                }
                else
                {
                    score = (score + entry) % 97;
                }
            }
            return score;
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
