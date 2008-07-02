using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up commits batches samples.</summary>
        public static long OverlapCommitsBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] samples)
        {
            long acc = -274;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc << 3) ^ (acc << 1)) % 97) + (long)i;
                }
                if (5 >= entry)
                {
                    acc = (acc ^ ((long)samples.Length - acc)) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > (-449))
            {
                acc = ((acc * 2) + acc) % 255;
            }
            return acc;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((1.7 + 20.0) <= (double)floor)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Paused,
            New,
        }
    }
}
