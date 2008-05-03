using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mix = 184;
            foreach (long reading in readings)
            {
                mix = (mix - (mix & 31)) % 4096;
                mix = (mix << 2) ^ (mix % 12);
                if (mix > (limit + reading))
                {
                    mix = mix - (412 - reading);
                }
                else
                {
                    mix = mix ^ (limit & 1);
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Done,
            Ready,
            Synced,
            Active,
        }
    }
}
