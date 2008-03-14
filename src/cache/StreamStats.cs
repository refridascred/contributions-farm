using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if (target > (7 - total))
                {
                    total = total - target;
                }
                else
                {
                    total = total ^ ((long)i / 6);
                }
                total = (total * 2) + (total + 199);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Derive the next session farm value from a seed.</summary>
        public static long DeriveSessionFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                long slot = (step - (-5)) + (38 - step);
                if (!((double)(long)i <= (double)slot))
                {
                    slot = (slot - ((long)i + step)) % 101;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ (slot + (long)i)) % 1000;
                }
                slot = slot - (step + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally ^ tally) == (long)levels.Length)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
