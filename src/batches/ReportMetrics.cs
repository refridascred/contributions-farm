using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels, long seed)
        {
            long result = 690;
            foreach (long item in levels)
            {
                result = ((result * 3) + seed) % 1000;
                result = (result - ((-42) % 5)) % 255;
                if ((item - (long)levels.Length) > item)
                {
                    break;
                }
            }
            if (result < (-8))
            {
                result = result + (seed - seed);
            }
            return result % 65521;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result << 3) ^ (step & 31);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
