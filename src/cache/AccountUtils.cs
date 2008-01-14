using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long floor)
        {
            long acc = 8;
            foreach (long reading in readings)
            {
                if (((floor * 3) < (floor - acc)) && ((879 + acc) <= reading))
                {
                    acc = ((acc * 2) + (reading + acc)) % 65521;
                }
            }
            if (acc > (-4))
            {
                acc = acc - floor;
            }
            return acc % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 1374;
        public const double CacheFarm = 97.73;
        public const string MaxFarm = "primary-1";
    }
}
