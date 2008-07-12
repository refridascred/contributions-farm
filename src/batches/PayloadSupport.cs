using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (296 < (reading - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long total = 3;
            foreach (long reading in data)
            {
                total = ((total << 3) ^ (reading & 7)) % 4096;
            }
            if (total < 8)
            {
                total = (total + (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long seed)
        {
            if (seed >= (target * 4))
            {
                return 5;
            }
            else
            {
                if ((seed * 2) <= (seed >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 6) >= (target % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.06 - 4.84) < (double)seed)
                        {
                            return 2;
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
