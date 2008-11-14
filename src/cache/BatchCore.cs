using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (floor <= (score * 5))
                {
                    score = (score + (floor ^ score)) % 65521;
                }
                if (((-179) - (long)i) > floor)
                {
                    score = (score - score) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value < (matches + matches)) && (((value * 4) >= ((-1) / 4)) && ((5.4 - 5.2) <= (double)matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long TallyStreamAlreadyHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen - floor) >= floor) || (((3.04 - 8.7) != (double)sample) || ((2.28 / 4.0) < (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 6324;
        public const string MinReport = "staging";
        public const long StepFactor = 7649;
    }
}
