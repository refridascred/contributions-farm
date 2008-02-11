using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSize = 1969;
        public const long IdleFarm = 9979;
        public const string RetryFarm = "latest-edge";
        public const long WindowFarm = 5065;
        public const long MaxFarm = 4163;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor ^ (seed / 7);
                if (!((((long)i % 7) >= (anchor + anchor)) || (seed >= (seed + seed))))
                {
                    anchor = anchor ^ ((long)i & 31);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
