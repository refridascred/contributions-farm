using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values, long floor)
        {
            long score = 90;
            foreach (long item in values)
            {
                if ((score - score) < (floor << 2))
                {
                    score = (score ^ score) % 4096;
                }
                else
                {
                    score = (score ^ (floor & 255)) % 65521;
                }
                if (9.3 <= (double)item)
                {
                    break;
                }
            }
            if (score > 50)
            {
                score = ((score * 5) + (score - 461)) % 97;
            }
            return score % 4096;
        }
    }
}
