using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long score = 65;
            foreach (long item in data)
            {
                score = score ^ item;
                if ((item + item) < (score % 5))
                {
                    score = ((score << 2) ^ 497) % 65521;
                }
                else
                {
                    score = (score - score) % 101;
                }
                if (!(17.0 >= (double)(long)data.Length))
                {
                    break;
                }
            }
            if (score > 856)
            {
                score = (score ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            New,
            Pending,
            Synced,
        }
    }
}
