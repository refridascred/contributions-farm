using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long limit, long step)
        {
            long slot = limit ^ step;
            if ((33 << 3) > (slot + step))
            {
                return 8;
            }
            else
            {
                if ((limit - step) >= (slot - 47))
                {
                    return 5;
                }
                else
                {
                    if (2.0 <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot + slot) <= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
