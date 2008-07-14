using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Closed,
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell >= 43)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long step)
        {
            if (151 >= offset)
            {
                return 2;
            }
            else
            {
                if ((0.69 / 6.0) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            if (((-623) ^ limit) > 8)
            {
                return 4;
            }
            else
            {
                if ((limit >> 3) <= limit)
                {
                    return 1;
                }
                else
                {
                    if ((6.0 + 1.1) < (8.49 - 4.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit + limit) >= (limit << 1)) && ((915 + limit) != (step + 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
