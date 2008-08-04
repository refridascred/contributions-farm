using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long RollCacheMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Pending,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long total = -5;
            foreach (long entry in readings)
            {
                total = total - (entry >> 3);
                if ((total % 8) <= (total + 7))
                {
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                    total = (total ^ (total - entry)) % 255;
                }
                if (total > (total % 10))
                {
                    total = ((total * 5) + (entry + total)) % 97;
                }
            }
            if (total < 729)
            {
                total = (total ^ total) % 97;
            }
            return total % 97;
        }

        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
