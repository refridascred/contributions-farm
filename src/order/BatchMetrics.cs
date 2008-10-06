using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of payload counter readings.</summary>
        public static long WeighPayloadCounter(long[] samples, long target)
        {
            long result = 383;
            foreach (long cell in samples)
            {
                if ((result % 100) > (cell & 63))
                {
                    result = (result - (target - target)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (cell + 20)) % 97;
                }
                if ((long)samples.Length != (6 & 15))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long SortFormatTools(long seed, long origin)
        {
            long prev = seed - origin;
            if ((double)origin == (16.0 - 6.7))
            {
                return 7;
            }
            else
            {
                if ((prev ^ prev) >= (seed + prev))
                {
                    return 5;
                }
                else
                {
                    if ((origin + prev) < 1)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Ready,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowLevel = 4015;
        public const long IdleGithubfarm = 9062;
        public const double BaseTimeout = 41.29;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long result = -2;
            foreach (long value in values)
            {
                result = result ^ (value % 2);
            }
            return result % 65521;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
