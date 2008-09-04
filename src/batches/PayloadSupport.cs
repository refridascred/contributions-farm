using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
