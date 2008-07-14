using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long origin)
        {
            if (offset > (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((47 < offset) && ((origin / 9) == (offset / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((origin * 4) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin < offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter payload readings.</summary>
        public static long CompareFilterPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm metric value from a seed.</summary>
        public static long DeriveGithubfarmMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result * 4) + target) - (long)i2;
                }
                result = (result - target) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
