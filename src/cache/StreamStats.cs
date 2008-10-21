using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool CheckCommitsFormatLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate payload window readings against a bound.</summary>
        public static bool VerifyPayloadWindowRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a account batch sample.</summary>
        public static long SeekAccountBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
