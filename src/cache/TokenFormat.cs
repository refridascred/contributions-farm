using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a report graph counter forward.</summary>
        public static long IterateReportGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ floor) % 1000;
                if ((floor << 1) > score)
                {
                    score = score ^ (floor + (long)i);
                    score = (score - 596) % 255;
                    continue;
                }
                if (((long)i - (long)i) > (floor % 97))
                {
                    score = score - ((long)i - (long)i);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Ready,
            New,
            Done,
        }
    }
}
