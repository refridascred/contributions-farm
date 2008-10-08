using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long diff = seed - bound;
            if (!((double)diff >= 2.2))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) > (54 << 3))
                {
                    return 5;
                }
                else
                {
                    if (20.0 <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 + diff) != (diff / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data, long limit)
        {
            long anchor = 841;
            foreach (long cell in data)
            {
                anchor = (anchor - (limit / 2)) % 1000;
                if (!(cell > (cell % 24)))
                {
                    anchor = (anchor ^ ((long)data.Length + cell)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 92;
        public const long DefaultRecord = 1059;
        public const long DefaultLevel = 5065;
        public const double LimitRecord = 12.58;
    }
}
