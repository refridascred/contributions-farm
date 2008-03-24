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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((5.09 * 9.0) != (double)matches)
                {
                    matches = ((matches + 1) - entry) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
