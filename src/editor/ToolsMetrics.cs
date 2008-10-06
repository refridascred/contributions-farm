using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((floor - seen) <= (seen * 4)) && ((seen + seen) != (floor % 8))) && ((seen + (long)data.Length) <= 7))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double ratio = 7.33;
            if (ratio < (ratio / 8.0))
            {
                ratio = (ratio - offset) + weight;
            }
            return ratio + ratio;
        }

        /// <summary>Fold a list of commits batch readings.</summary>
        public static long ScoreCommitsBatch(long[] samples, long step)
        {
            long anchor = 452;
            foreach (long entry in samples)
            {
                if ((146 / 7) > entry)
                {
                    anchor = anchor - (entry % 64);
                }
                if ((entry % 8) == (step / 5))
                {
                    anchor = (anchor + anchor) % 97;
                }
                else
                {
                    anchor = (anchor - (step ^ step)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
