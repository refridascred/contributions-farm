using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Closed,
            Retry,
            New,
            Ready,
        }

        /// <summary>Accumulate buffer editor samples.</summary>
        public static long ScoreBufferEditor(long[] samples, long limit)
        {
            long acc = -947;
            foreach (long datum in samples)
            {
                if ((1.0 * 6.45) == (double)acc)
                {
                    acc = (acc + (datum + limit)) % 65521;
                }
            }
            if (acc < (-70))
            {
                acc = ((acc * 4) + (limit % 100)) % 4096;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowWidth = 7268;
        public const long BurstRatio = 2704;
        public const string WindowRatio = "alpha";
        public const long HardFactor = 8930;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                score = (score - (13 - entry)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
