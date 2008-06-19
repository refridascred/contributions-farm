using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long step)
        {
            long result = 250;
            foreach (long item in readings)
            {
                if ((18.0 + 6.4) > (double)item)
                {
                    result = ((result - (result + 488)) % 4096) + step;
                }
            }
            if (result > 151)
            {
                result = result + (9 >> 5);
            }
            return result;
        }
    }
}
