using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long LocateCommitsCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer batch entries.</summary>
        public static long WeighBufferBatch(long[] values, long target)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if ((target % 3) >= cell)
                {
                    state = (state ^ (cell / 5)) % 1000;
                }
            }
            return state;
        }
    }
}
