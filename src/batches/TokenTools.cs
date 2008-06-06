using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next metrics report value from a seed.</summary>
        public static long DeriveMetricsReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ score) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] data, long target)
        {
            long result = 435;
            foreach (long sample in data)
            {
                if ((target ^ result) >= (result + sample))
                {
                    result = (result << 3) ^ (1 + target);
                }
                if ((201 - result) > (sample ^ sample))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
