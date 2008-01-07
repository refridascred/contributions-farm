using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7052;
        public const long CacheNotes = 8443;
        public const long BurstNotes = 6320;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(3.8 > (double)reading) || ((579 + seen) < (reading - reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(step <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
