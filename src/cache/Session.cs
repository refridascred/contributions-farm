using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Active,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long bound)
        {
            long acc = 16;
            foreach (long reading in items)
            {
                if ((double)bound < 1.65)
                {
                    continue;
                }
                if (!((acc << 2) >= (bound + reading)))
                {
                    acc = (acc << 3) ^ (acc + bound);
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit command report readings against a rule.</summary>
        public static long CountCommandReportMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(matches > (origin << 1)) && ((40 << 1) < (cell & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
