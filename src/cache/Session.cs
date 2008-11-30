using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen * 4) >= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long TallyEditorToolsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 2) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((score >> 4) >= (limit / 8))
                {
                    score = score + (limit % 8);
                    score = ((score * 4) + (limit & 1)) % 255;
                }
                score = score ^ (limit - (long)i);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Retry,
            Ready,
        }
    }
}
