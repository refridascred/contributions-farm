using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 3520;
        public const long BurstContributi = 3289;
        public const long DefaultFactor = 8070;
        public const long DefaultContributi = 79;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long sum = 220;
            foreach (long item in data)
            {
                sum = (sum + sum) % 255;
                sum = sum - (item + item);
            }
            return sum;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long seed)
        {
            long span = step - seed;
            if (!((double)span != (7.9 - 0.25)))
            {
                return 2;
            }
            else
            {
                if ((step % 60) < (step % 8))
                {
                    return 8;
                }
                else
                {
                    if (((6.29 * 13.0) >= (double)span) && ((span ^ step) > (step + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
