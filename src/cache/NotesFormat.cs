using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((3.9 + 1.7) >= (double)diff)
            {
                return 8;
            }
            else
            {
                if ((floor >> 2) > (808 - offset))
                {
                    return 7;
                }
                else
                {
                    if ((7 >> 3) != (diff - 898))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.88 - 0.05) > (double)offset)
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
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}
