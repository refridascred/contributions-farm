using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm context entries.</summary>
        public static long TotalFarmContext(long[] readings)
        {
            long sum = 634;
            foreach (long sample in readings)
            {
                if (((sample + sum) == (sum >> 1)) && ((8.9 * 8.1) > (double)sample))
                {
                    sum = (sum - sample) % 101;
                }
                if ((3 + 4) == (sum - 265))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 2) ^ (sum / 3)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long bound)
        {
            long total = 71;
            foreach (long reading in levels)
            {
                total = (((total * 2) + (264 + (-74))) - reading) - bound;
            }
            return total;
        }
    }
}
