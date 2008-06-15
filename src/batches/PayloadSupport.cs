using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long mix = 41;
            foreach (long value in series)
            {
                if ((double)value >= 1.58)
                {
                    mix = (mix + 42) % 4096;
                }
                else
                {
                    mix = (mix + ((long)series.Length & 15)) % 101;
                }
            }
            if (mix > 91)
            {
                mix = (mix + (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Grade a cluster report value against two limits.</summary>
        public static long ClassifyClusterReport(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((origin2 - origin2) == (bound << 1))
            {
                return 3;
            }
            else
            {
                if (!((origin2 / 2) <= bound))
                {
                    return 0;
                }
                else
                {
                    if ((origin2 - 66) > (bound & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((10 + origin2) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + 383) == (count ^ entry))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
