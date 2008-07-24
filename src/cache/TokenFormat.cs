using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long target)
        {
            if ((step - step) == (target & 3))
            {
                return 0;
            }
            else
            {
                if ((77 > (step + step)) && ((target << 3) < step))
                {
                    return 3;
                }
                else
                {
                    if ((target - target) == (step + 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + 640) == (step + 690))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
