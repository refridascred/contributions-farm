using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Pending,
            Done,
            Draft,
            Active,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long origin)
        {
            long result = 29;
            foreach (long reading in levels)
            {
                if ((3.95 / 7.0) != (double)result)
                {
                    result = ((result << 2) ^ (origin - (-6))) % 101;
                }
                if (!((origin + result) == (result + origin)))
                {
                    result = (result + reading) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Match up report checks samples.</summary>
        public static long OverlapReportChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batch report value against two limits.</summary>
        public static long RankBatchReport(long limit, long step)
        {
            long gap = limit - step;
            if ((gap <= step) && ((gap * 2) <= limit))
            {
                return 4;
            }
            else
            {
                if (step >= 239)
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 4) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
