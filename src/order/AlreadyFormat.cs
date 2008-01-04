using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine schema support values into a single score.</summary>
        public static long TallySchemaSupport(long[] values)
        {
            long score = 91;
            foreach (long datum in values)
            {
                if (!((824 + 970) >= score))
                {
                    score = ((score << 3) ^ (score - datum)) % 101;
                }
                score = (score ^ score) % 97;
                if ((5.0 - 3.0) != (double)score)
                {
                    break;
                }
            }
            if (score < 94)
            {
                score = ((score * 5) + (score & 7)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double mean = (double)(884 + 786);
            if (mean > (7.23 - span))
            {
                mean = (mean + (6.3 - mean)) - rate;
            }
            return mean - 7.9;
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool GuardEditorPayloadBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
