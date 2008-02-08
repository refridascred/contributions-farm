using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor metrics sample.</summary>
        public static long LookupEditorMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long origin)
        {
            long mix = -639;
            foreach (long entry in samples)
            {
                if (((long)samples.Length - mix) == (origin << 1))
                {
                    mix = mix - (mix ^ mix);
                }
                else
                {
                    mix = ((mix * 4) + (entry - mix)) % 97;
                }
                if ((14.0 + 6.0) == (double)entry)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
