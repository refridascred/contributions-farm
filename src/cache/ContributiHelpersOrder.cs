using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long score = 36;
            foreach (long entry in samples)
            {
                if ((score >> 4) != (7 << 2))
                {
                    score = (score * 5) + entry;
                }
            }
            if (score > 12)
            {
                score = (score + (684 * 3)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Active,
            Ready,
        }
    }
}
