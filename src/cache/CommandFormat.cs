using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long origin)
        {
            long state = 32;
            foreach (long cell in readings)
            {
                if ((origin / 8) <= origin)
                {
                    state = state - cell;
                    continue;
                }
                state = state - (state - cell);
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Failed,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (score << 1)) % 4096;
                if (score >= (score << 1))
                {
                    score = (score + (5 + offset)) % 255;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool CheckTokenChannelLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
