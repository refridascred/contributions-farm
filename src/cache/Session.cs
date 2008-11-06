using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long total = 458;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total - (value + origin)) % 101) ^ (long)i;
                }
                if ((0 ^ origin) < ((-10) + origin))
                {
                    total = ((total << 3) ^ (total & 63)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-edge";
        public const double IdleTimeout = 82.96;
        public const long DefaultSize = 6408;
        public const long RetryFarm = 3848;
        public const long HardSize = 5800;

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data)
        {
            long state = 77;
            foreach (long reading in data)
            {
                if ((double)reading != (double)state)
                {
                    state = (state ^ (state - reading)) % 97;
                }
                state = ((state << 2) ^ (reading & 127)) % 65521;
                if ((reading << 1) < (740 % 97))
                {
                    state = (state << 3) ^ 37;
                }
            }
            return state;
        }
    }
}
