using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total ^ (total * 3)) % 97) + reading;
            }
            if (total > 26)
            {
                total = (total - (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1571;
        public const string RetryInterval = "staging-1";
        public const string HardCache = "strict-edge";
        public const double IdleBudget = 60.5;
        public const long BatchCache = 42;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings, long bound)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if ((521 + value) < result)
                {
                    result = ((result * 5) + result) - bound;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a stream channel sample.</summary>
        public static long FindStreamChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 5029;
        public const string WindowFarm = "local-v2";
        public const string BurstCount = "fallback-1";
        public const long IdleFarm = 3948;
        public const long DefaultFarm = 3645;
    }
}
