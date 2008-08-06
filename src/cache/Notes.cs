using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 2.66;
        public const string HardMetrics = "standard-1";
        public const double RetryMetrics = 52.17;
        public const long BaseSpan = 5498;
        public const long StepDepth = 6046;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long carry = 746;
            foreach (long value in levels)
            {
                carry = ((carry << 3) ^ (value >> 2)) % 1000;
                carry = ((carry * 4) + (carry & 1)) % 255;
            }
            if (carry > 936)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Roll a notes support counter forward.</summary>
        public static long SeriesNotesSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ ((long)i + (-9))) % 255;
                score = ((score * 5) + (30 - 41)) % 101;
                if ((double)score <= (10.0 / 8.0))
                {
                    score = ((score * 4) + ((long)i << 3)) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
