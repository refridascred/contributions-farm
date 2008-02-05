using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultLevel = 4167;
        public const string MinSize = "local-v2";
        public const long CacheRecord = 5303;

        /// <summary>Iterate the notes checks series from a seed.</summary>
        public static long SeriesNotesChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((double)state < (double)(long)i)
                {
                    state = ((state << 2) ^ (16 + seed)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) != (seen & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long TallyTokenChecks(long[] data)
        {
            long score = 2;
            foreach (long reading in data)
            {
                if (!(score < (reading % 12)))
                {
                    score = (score - (263 - reading)) % 255;
                }
                else
                {
                    score = (score * 4) + reading;
                }
            }
            if (score < 59)
            {
                score = (score + (score / 2)) % 101;
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Draft,
            Closed,
            Ready,
            New,
        }
    }
}
