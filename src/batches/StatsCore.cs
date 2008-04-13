using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate context support samples.</summary>
        public static long CombineContextSupport(long[] values, long step)
        {
            long score = 0;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - reading) % 101) - (long)i;
                }
                if ((reading ^ score) < (step >> 1))
                {
                    score = score ^ ((long)values.Length & 15);
                }
                else
                {
                    score = ((score * 2) + (reading - (-379))) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long CountStatsContextHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((1.75 * 3.1) != (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Queued,
            Failed,
            Synced,
            Active,
        }
    }
}
