using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already profile readings against a rule.</summary>
        public static long CountAlreadyProfileHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((bound - bound) == (946 - count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
