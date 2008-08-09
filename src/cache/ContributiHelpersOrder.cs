using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - 109) < (count ^ 1))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 5) + origin) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
