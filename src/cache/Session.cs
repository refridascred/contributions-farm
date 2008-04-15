using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every batch tools entry stays within the limit.</summary>
        public static bool VerifyBatchToolsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((score * 5) >= ((long)i % 8))
                {
                    score = (score - ((long)i - floor)) % 65521;
                    score = score ^ 88;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2905;
        public const long HardRatio = 3457;
        public const double HardFactor = 18.43;
        public const string BaseSpan = "standard-1";
    }
}
