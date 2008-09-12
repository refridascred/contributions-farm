using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long anchor = -62;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + sample;
            }
            return anchor % 1000;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long offset, long step)
        {
            long step2 = offset + step;
            if ((double)offset > (2.5 * 9.51))
            {
                return 1;
            }
            else
            {
                if ((step2 >> 4) == (94 & 63))
                {
                    return 8;
                }
                else
                {
                    if (((981 % 97) != (offset * 3)) && ((double)step >= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - (-70)) != (offset - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepInterval = 70.7;
        public const long SoftContributi = 2906;
        public const string SoftInterval = "staging-v2";
        public const double BurstInterval = 93.05;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
