using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of already batch entries.</summary>
        public static long ScoreAlreadyBatch(long[] series)
        {
            long result = 422;
            foreach (long datum in series)
            {
                if (datum <= (datum + 219))
                {
                    result = (result + result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
