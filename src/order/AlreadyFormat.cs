using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a record queue pair into a bucket.</summary>
        public static long BucketRecordQueue(long limit, long seed)
        {
            if (5 <= limit)
            {
                return 8;
            }
            else
            {
                if ((limit % 97) > (seed - limit))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 2) >= (limit >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits < (cell << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long ScoreOrderFarm(long[] items)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                if (((long)items.Length + reading) > (carry - reading))
                {
                    carry = (carry * 2) + (reading ^ carry);
                }
            }
            return carry % 4096;
        }
    }
}
