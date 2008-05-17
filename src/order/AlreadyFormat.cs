using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long limit)
        {
            long step = target - limit;
            if ((limit - limit) > (step + 65))
            {
                return 5;
            }
            else
            {
                if (target >= (target >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 1) > (limit & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step + limit) > step) || ((step & 15) < ((-2) - 9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((3.0 / 6.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)target < (8.0 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if (target < (target % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
