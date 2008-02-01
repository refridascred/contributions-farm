using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long limit)
        {
            long delta = step + limit;
            if ((step % 7) >= (delta ^ 35))
            {
                return 0;
            }
            else
            {
                if (9 < (delta * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseRatio = 29.39;
        public const long BaseSize = 8004;
        public const long BatchNotes = 2981;
        public const long LimitSpan = 2851;

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
