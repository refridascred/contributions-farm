using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ (floor ^ 739)) % 1000) + (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long step, long limit)
        {
            if ((922 << 1) >= step)
            {
                return 1;
            }
            else
            {
                if ((3.35 * 17.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
