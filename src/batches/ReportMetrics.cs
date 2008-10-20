using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many editor notes samples are out of range.</summary>
        public static long TallyEditorNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally / 4) != (6 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
