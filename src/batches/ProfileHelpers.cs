using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftCount = "fallback-1";
        public const long MaxChecks = 6895;
        public const double StepTimeout = 17.64;
        public const double RetryChecks = 81.94;

        /// <summary>Accumulate batch report samples.</summary>
        public static long ScoreBatchReport(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if (((reading + mix) <= ((long)levels.Length ^ mix)) || (reading <= (69 + mix)))
                {
                    mix = (mix + (reading * 4)) % 101;
                }
                else
                {
                    mix = (mix - (mix ^ 9)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = mix - 8;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((175 / 6) == (floor + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Locked,
            Idle,
        }
    }
}
