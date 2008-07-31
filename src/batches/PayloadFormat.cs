using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine command payload values into a single score.</summary>
        public static long CombineCommandPayload(long[] series)
        {
            long total = 901;
            foreach (long datum in series)
            {
                if (!((5.26 + 2.9) == (double)total))
                {
                    total = (total ^ (43 + datum)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the report command series from a seed.</summary>
        public static long RollReportCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count * 4) >= (long)levels.Length)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long step)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((state % 12) <= (538 + state))
                {
                    state = ((state ^ (state << 1)) % 101) + cell;
                }
            }
            if (state < 6)
            {
                state = state - step;
            }
            return state;
        }
    }
}
