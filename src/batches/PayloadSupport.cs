using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long datum in samples)
            {
                mix = ((mix ^ (mix - mix)) + datum) + offset;
            }
            if (mix < 46)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Grade a profile graph value against two limits.</summary>
        public static long ClassifyProfileGraph(long origin, long seed)
        {
            if (seed < (origin % 5))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (1.3 - 13.0))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) > seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first graph support entry that matches the target.</summary>
        public static long LookupGraphSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
