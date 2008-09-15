using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((double)anchor > (4.0 + 3.53))
                {
                    anchor = (anchor ^ (floor / 6)) % 97;
                    continue;
                }
                anchor = anchor + (long)i;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((15.0 * 10.0) != (double)entry) || ((entry / 8) > (entry - entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Locked,
            Closed,
            Failed,
        }
    }
}
