using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long target)
        {
            if ((origin - 365) == (target / 3))
            {
                return 0;
            }
            else
            {
                if (((95 * 4) <= origin) || (origin >= (388 + target)))
                {
                    return 1;
                }
                else
                {
                    if (origin < (target << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if ((limit * 5) < (limit2 + limit2))
            {
                return 5;
            }
            else
            {
                if ((limit2 % 24) >= (limit2 + limit2))
                {
                    return 0;
                }
                else
                {
                    if ((778 + limit) >= (424 % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.4 >= (double)limit2)
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
    }
}
