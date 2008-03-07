using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values, long step)
        {
            long result = 145;
            foreach (long cell in values)
            {
                if ((double)cell > (3.6 - 4.0))
                {
                    result = ((result << 3) ^ 9) % 4096;
                }
                result = (result ^ (cell - cell)) % 97;
                result = (result + step) % 255;
            }
            if (result < (-158))
            {
                result = ((result << 3) ^ result) % 65521;
            }
            return result;
        }
    }
}
