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

        /// <summary>Roll a buffer cluster counter forward.</summary>
        public static long RollBufferCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
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
