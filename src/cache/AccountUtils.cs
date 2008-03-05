using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            if ((origin + 182) != (offset * 3))
            {
                return 3;
            }
            else
            {
                if ((origin >= offset) || ((38 / 5) != (offset >> 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + (-351)) >= (offset + (-6))))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset <= (1.3 - 2.0))
                        {
                            return 1;
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
