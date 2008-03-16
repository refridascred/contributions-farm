using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Queued,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long limit)
        {
            long acc = 834;
            foreach (long datum in samples)
            {
                if ((limit & 7) <= acc)
                {
                    acc = ((acc << 3) ^ (487 - acc)) + datum;
                }
                if (!(limit < (250 - limit)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit stats tools readings against a rule.</summary>
        public static long MeasureStatsToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(17.0 >= (double)count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Closed,
        }
    }
}
