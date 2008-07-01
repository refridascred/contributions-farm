using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine record stats values into a single score.</summary>
        public static long TallyRecordStats(long[] readings, long step)
        {
            long result = -48;
            foreach (long datum in readings)
            {
                result = (result - (step & 255)) + datum;
            }
            if (result > 8)
            {
                result = (result << 2) ^ (step + result);
            }
            return result;
        }

        /// <summary>Derive the next githubfarm editor value from a seed.</summary>
        public static long DeriveGithubfarmEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long anchor = 93;
            foreach (long item in samples)
            {
                if (anchor > (anchor * 5))
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) + item;
                }
            }
            return anchor % 1000;
        }
    }
}
