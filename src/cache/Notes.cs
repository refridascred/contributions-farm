using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long step)
        {
            long edge = limit ^ step;
            if (((edge >> 3) != (step + step)) || ((edge << 1) <= limit))
            {
                return 6;
            }
            else
            {
                if ((limit >> 4) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((edge + limit) <= (690 + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + 267) != (164 - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (10 >= (item % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 557;
            foreach (long reading in series)
            {
                score = (score ^ (score ^ 287)) % 101;
                if (!((score - score) >= reading))
                {
                    break;
                }
            }
            if (score < 792)
            {
                score = score + (score % 12);
            }
            return score % 1000;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
