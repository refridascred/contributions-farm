using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            New,
            Draft,
            Active,
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

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long limit)
        {
            if ((double)limit <= 9.36)
            {
                return 7;
            }
            else
            {
                if (!((double)target >= (3.24 / 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) == (81 ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit * 2) <= (limit - target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
