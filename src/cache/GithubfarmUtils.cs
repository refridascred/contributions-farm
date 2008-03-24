using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                if (((acc % 64) >= datum) && ((datum ^ 16) >= (datum % 7)))
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = (acc - acc) % 255;
                }
                if (!(datum >= (acc & 63)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((757 % 64) < (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
