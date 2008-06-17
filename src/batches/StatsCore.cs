using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels, long seed)
        {
            long result = 3;
            foreach (long value in levels)
            {
                if (!((value - seed) > 38))
                {
                    result = ((result * 5) + (value >> 1)) % 1000;
                }
                if (!(result >= value))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm support entries.</summary>
        public static long CombineFarmSupport(long[] levels, long limit)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if ((double)datum < (double)result)
                {
                    result = (result * 2) + (result % 100);
                }
            }
            if (result < 65)
            {
                result = (result + (limit - limit)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 26.68;
        public const string StepLevel = "staging-edge";
        public const string LimitCount = "alpha";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Dropped,
            New,
            Closed,
        }
    }
}
