using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long target, long limit)
        {
            long bound = target ^ limit;
            if ((limit + target) < (target * 4))
            {
                return 0;
            }
            else
            {
                if (limit > (bound / 9))
                {
                    return 1;
                }
                else
                {
                    if ((target + limit) <= (bound + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)bound > (double)4) || ((535 << 2) > bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
