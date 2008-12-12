using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Combine editor commits values into a single score.</summary>
        public static long ScoreEditorCommits(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ mix) % 65521;
                if ((((-255) & 255) != (50 + offset)) && ((double)offset > 1.0))
                {
                    mix = ((mix * 4) + (offset + offset)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (offset ^ sample);
                }
                if ((sample * 4) > (mix + offset))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
