using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank payload token input into a small class.</summary>
        public static long GradePayloadToken(long target, long bound)
        {
            long span = target - bound;
            if ((130 - span) < target)
            {
                return 6;
            }
            else
            {
                if ((target - bound) > (6 - bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound + span) <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target > bound) && ((target % 16) < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((19.0 + 7.13) == (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
