using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Match up session counter samples.</summary>
        public static long MatchSessionCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 3100;
        public const long MinDepth = 9219;
        public const long MaxCount = 553;
        public const long HardStats = 1663;

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches ^ value) > (origin * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long total = 249;
            foreach (long cell in data)
            {
                total = total - (cell + cell);
                if (649 < total)
                {
                    total = total + total;
                }
                if (((long)data.Length ^ cell) > total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
