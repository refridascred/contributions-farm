using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            if ((floor << 1) < limit)
            {
                return 7;
            }
            else
            {
                if ((limit * 3) <= (limit ^ 144))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheBudget = 8251;
        public const double WindowRatio = 93.01;
        public const long RetryBudget = 5767;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long seed)
        {
            long total = 897;
            foreach (long sample in series)
            {
                total = (total - (sample - total)) - seed;
                if ((sample & 3) <= (sample & 255))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = ((total * 4) + (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            New,
            Pending,
        }
    }
}
