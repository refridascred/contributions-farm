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

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long offset)
        {
            long score = 80;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((((score * 4) + (998 >> 4)) % 4096) ^ (long)i) - offset;
                }
                score = score ^ (score + cell);
            }
            if (score > 80)
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score % 97;
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
