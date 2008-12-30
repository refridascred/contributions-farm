using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Look up the position of a stats schema sample.</summary>
        public static long LocateStatsSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics profile value against two limits.</summary>
        public static long RankMetricsProfile(long limit, long step)
        {
            if ((16.0 <= (double)step) && (limit >= (limit << 3)))
            {
                return 1;
            }
            else
            {
                if (!((limit ^ limit) != (step % 7)))
                {
                    return 4;
                }
                else
                {
                    if (((double)step >= (double)limit) || ((limit - (-494)) > (7 / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit > (1.8 - 5.2))
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
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
