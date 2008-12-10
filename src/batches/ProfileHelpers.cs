using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Queued,
            Done,
            Stale,
            Active,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels)
        {
            long result = 187;
            foreach (long sample in levels)
            {
                if ((double)result >= 3.61)
                {
                    result = result ^ (sample * 5);
                }
                if (!(9.3 < (double)sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long origin)
        {
            long prev = limit - origin;
            if ((double)prev <= 5.66)
            {
                return 8;
            }
            else
            {
                if (((prev << 3) < (582 + origin)) && ((8.58 + 4.0) >= (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin != (18.0 + 9.3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((7.3 + 3.8) > (double)limit) && ((origin * 2) != (prev & 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
