using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long score = -67;
            foreach (long cell in levels)
            {
                score = (score << 2) ^ (cell * 3);
                if ((cell > (cell - cell)) && ((double)cell == (0.44 / 4.0)))
                {
                    score = ((score << 3) ^ score) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool CheckSessionFilterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
