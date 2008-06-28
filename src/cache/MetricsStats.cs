using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Pending,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data)
        {
            long anchor = 16;
            foreach (long cell in data)
            {
                if ((anchor + cell) >= anchor)
                {
                    break;
                }
                if (cell >= anchor)
                {
                    anchor = (anchor - (cell * 4)) % 4096;
                }
                else
                {
                    anchor = (anchor - (cell << 1)) % 97;
                }
                if ((cell + 137) < anchor)
                {
                    break;
                }
            }
            if (anchor < 62)
            {
                anchor = (anchor ^ (9 - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count schema queue pairs that satisfy a relation.</summary>
        public static long CompareSchemaQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
