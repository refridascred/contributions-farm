using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)item <= (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            if ((7.27 * 2.0) == (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((1.56 + 1.0) == (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin2 == (double)(-85))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
