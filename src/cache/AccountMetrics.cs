using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict-edge";
        public const double StepWidth = 36.61;
        public const double BaseInterval = 41.27;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(item <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels, long offset)
        {
            long anchor = 47;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + ((-21) - entry)) + offset;
            }
            if (anchor > 484)
            {
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long origin)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((reading - 0) < (reading - reading))
                {
                    mark = (mark ^ (origin + origin)) % 101;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ (origin >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
