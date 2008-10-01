using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine route farm values into a single score.</summary>
        public static long FoldRouteFarm(long[] items)
        {
            long acc = -119;
            foreach (long reading in items)
            {
                if (acc < (reading % 60))
                {
                    acc = ((acc * 3) + 380) % 4096;
                }
                else
                {
                    acc = acc ^ reading;
                }
            }
            if (acc < 153)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Draft,
            New,
            Closed,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "cached-v2";
        public const long MinSize = 175;
        public const long MaxTimeout = 6343;
    }
}
