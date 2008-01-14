using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long sum = 173;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ (origin - origin)) % 1000;
                if ((origin >> 4) != (sum * 4))
                {
                    sum = (sum ^ (datum + datum)) % 97;
                }
                if (datum > (sum - origin))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long seed)
        {
            if (((target + seed) > target) && ((seed / 3) <= seed))
            {
                return 3;
            }
            else
            {
                if (((double)target < 10.0) || ((target ^ 32) >= (target << 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
