using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long mix = 221;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Idle,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long score = -18;
            foreach (long entry in items)
            {
                score = (score - (score >> 3)) % 4096;
                if ((0.8 <= (double)score) || (16 >= (entry & 127)))
                {
                    score = (score * 2) + 910;
                }
            }
            return score;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Retry,
            Closed,
            Active,
        }
    }
}
