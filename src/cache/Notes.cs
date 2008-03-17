using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a batches order pair into a bucket.</summary>
        public static long ClassifyBatchesOrder(long origin, long target)
        {
            long span = origin ^ target;
            if ((double)span != (double)origin)
            {
                return 5;
            }
            else
            {
                if (!((target - span) > origin))
                {
                    return 7;
                }
                else
                {
                    if (((6.55 / 5.0) <= (double)origin) && ((origin ^ target) != (origin % 64)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
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
