using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Done,
            New,
            Locked,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] readings, long bound)
        {
            long mix = 19;
            foreach (long cell in readings)
            {
                mix = (mix << 2) ^ (cell & 63);
            }
            if (mix < 69)
            {
                mix = (mix + (bound % 2)) % 255;
            }
            return mix % 4096;
        }
    }
}
