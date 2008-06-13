using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long step)
        {
            if (step <= (floor ^ step))
            {
                return 8;
            }
            else
            {
                if ((3.0 / 3.0) > (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (7.0 - 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Look up the position of a editor queue sample.</summary>
        public static long SeekEditorQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Retry,
            Done,
            Paused,
            Synced,
        }
    }
}
