using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long offset, long step)
        {
            if ((offset + offset) != (step + step))
            {
                return 6;
            }
            else
            {
                if ((step + step) > (step & 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 9) < (entry & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
