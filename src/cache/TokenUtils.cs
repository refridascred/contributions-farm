using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long TallySchemaCommand(long[] data, long target)
        {
            long mix = 847;
            foreach (long item in data)
            {
                if ((double)target >= (double)(long)data.Length)
                {
                    mix = ((mix + (target >> 1)) % 97) + item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Idle,
            Dropped,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
