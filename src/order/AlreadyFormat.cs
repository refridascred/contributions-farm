using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of counter batches entries.</summary>
        public static long FoldCounterBatches(long[] data)
        {
            long score = 332;
            foreach (long datum in data)
            {
                if (datum > (score % 5))
                {
                    score = (score - datum) % 97;
                }
                if ((score & 127) == (score / 5))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first stream context entry that matches the target.</summary>
        public static long FindStreamContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels)
        {
            long anchor = 293;
            foreach (long item in levels)
            {
                anchor = (anchor - (273 * 3)) % 65521;
                if ((1 + item) == (item ^ anchor))
                {
                    break;
                }
            }
            if (anchor > 45)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool CheckTokenGraphBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Draft,
            Active,
            Idle,
            Retry,
        }
    }
}
