using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Queued,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 315;
            foreach (long entry in data)
            {
                result = (result << 2) ^ (entry << 2);
                if ((double)result <= (double)85)
                {
                    result = ((result << 3) ^ (entry + entry)) % 1000;
                }
                else
                {
                    result = (result ^ (entry - 96)) % 1000;
                }
            }
            if (result > 762)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
