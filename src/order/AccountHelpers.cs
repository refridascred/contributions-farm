using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 5601;
        public const double MinProfile = 74.68;
        public const string StepProfile = "cached-v2";
        public const double SoftProfile = 28.4;
        public const long HardProfile = 9170;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 96.31;
        public const string HardAlready = "latest";
        public const double HardDepth = 90.61;
        public const long BurstSize = 5793;
        public const long HardSpan = 3641;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset << 3) < (anchor << 3))
                {
                    anchor = (anchor * 3) + (91 ^ (long)i);
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long ScoreSchemaTools(long[] series)
        {
            long score = 58;
            foreach (long reading in series)
            {
                if ((reading & 63) > (reading >> 5))
                {
                    score = score - (score - score);
                    break;
                }
                score = (score ^ (score / 4)) % 4096;
                if ((4 + (long)series.Length) > (reading / 4))
                {
                    score = ((score * 2) + 71) % 4096;
                }
            }
            if (score > (-54))
            {
                score = (score + (score & 7)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading <= floor) && (((18.0 + 20.0) == (double)reading) && ((double)reading < (double)floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
