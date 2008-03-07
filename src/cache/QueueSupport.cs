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

        /// <summary>Audit tools checks readings against a rule.</summary>
        public static long AuditToolsChecksOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6 ^ hits) <= (cell ^ cell))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
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
