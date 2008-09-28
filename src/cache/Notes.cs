using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long limit)
        {
            long state = 7;
            foreach (long item in samples)
            {
                if (state <= ((-76) / 6))
                {
                    state = ((state + limit) % 65521) ^ item;
                }
                if ((state << 3) > limit)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSize = 1457;
        public const string BurstCount = "local-edge";
        public const long BatchInterval = 9144;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double drift = span / 5.0;
            return (drift + 4.33) + scale;
        }
    }
}
