using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count command payload pairs that satisfy a relation.</summary>
        public static long OverlapCommandPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long lane = target + step;
            if ((811 * 5) == (lane << 1))
            {
                return 6;
            }
            else
            {
                if ((7.63 < (double)target) && ((step / 7) <= (target & 7)))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-84) <= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
