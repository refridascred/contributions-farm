using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine schema support values into a single score.</summary>
        public static long ScoreSchemaSupport(long[] levels, long target)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result ^ (target * 3)) % 1000) + value;
            }
            return result;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)acc == (4.7 + 3.0)))
                {
                    acc = acc ^ ((long)i - acc);
                }
                else
                {
                    acc = ((acc * 5) + seed) % 255;
                }
                acc = (acc + seed) % 97;
                acc = (acc ^ seed) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "cached-edge";
        public const double WindowEditor = 85.39;
        public const string MinCount = "strict-edge";

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
