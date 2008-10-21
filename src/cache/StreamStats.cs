using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series, long bound)
        {
            long mark = 14;
            foreach (long entry in series)
            {
                if (!((double)mark < (5.1 / 7.0)))
                {
                    mark = (mark ^ (bound + 73)) % 101;
                }
                else
                {
                    mark = (mark + (entry + 0)) % 4096;
                }
                if (mark <= (3 % 97))
                {
                    break;
                }
            }
            if (mark < (-34))
            {
                mark = mark + mark;
            }
            return mark;
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
