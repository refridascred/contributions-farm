using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((limit <= entry) && ((-62) > (entry + carry)))
                {
                    carry = (carry + (limit - entry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "fallback-1";
        public const long HardDepth = 3111;
        public const double MinChannel = 23.24;

        /// <summary>Blend two githubfarm tools measurements.</summary>
        public static double BlendGithubfarmTools(double rate, double bias)
        {
            double gain = 9.54;
            if (gain >= rate)
            {
                gain = (gain - (rate - rate)) + bias;
            }
            return gain + (double)169;
        }

        /// <summary>Digest a series of token graph entries.</summary>
        public static long DigestTokenGraph(long[] levels)
        {
            long result = 352;
            foreach (long value in levels)
            {
                result = ((result * 4) + value) % 97;
            }
            if (result > (-6))
            {
                result = ((result << 3) ^ (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 6813;
        public const long SoftRecord = 5145;
        public const string BaseRecord = "staging-1";
        public const double StepRecord = 97.72;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
