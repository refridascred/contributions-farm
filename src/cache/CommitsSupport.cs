using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank schema report input into a small class.</summary>
        public static long BucketSchemaReport(long origin, long step)
        {
            if (((5 - step) < origin) || ((double)step > 4.89))
            {
                return 0;
            }
            else
            {
                if (!((step ^ step) <= (step + step)))
                {
                    return 8;
                }
                else
                {
                    if (!((origin + origin) < 35))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= (origin << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if ((17 >> 1) <= (limit % 100))
            {
                return 8;
            }
            else
            {
                if (((8 - limit) <= (limit2 + (-7))) || ((-4) >= limit2))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (7.82 - 5.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) == (865 + limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
