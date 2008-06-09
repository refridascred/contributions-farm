using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + item) < (item + 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Derive the next cluster batches value from a seed.</summary>
        public static long SeriesClusterBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long origin)
        {
            long mix = 3;
            foreach (long reading in data)
            {
                if ((double)reading >= (5.96 - 2.49))
                {
                    mix = (mix - mix) % 65521;
                    mix = mix + mix;
                }
                if ((66 - reading) != (reading >> 5))
                {
                    mix = (mix + (origin + reading)) % 65521;
                }
                else
                {
                    mix = (mix * 3) + (mix + 18);
                }
            }
            if (mix < 384)
            {
                mix = mix + 4;
            }
            return mix;
        }
    }
}
