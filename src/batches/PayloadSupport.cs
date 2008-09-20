using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen << 1) > seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a checks farm value against two limits.</summary>
        public static long SortChecksFarm(long floor, long origin)
        {
            long cur = floor + origin;
            if ((origin + 714) >= (origin / 5))
            {
                return 7;
            }
            else
            {
                if (7.79 > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((3 + floor) >= 72)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((cur - floor) >= (cur ^ cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
