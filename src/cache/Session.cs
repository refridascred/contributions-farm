using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long limit, long step)
        {
            long step2 = limit ^ step;
            if ((step2 - 4) <= step)
            {
                return 2;
            }
            else
            {
                if (limit < (limit + step2))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (double)step2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 & 15) > limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
