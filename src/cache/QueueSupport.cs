using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long origin)
        {
            long score = 24;
            foreach (long value in readings)
            {
                score = ((score * 5) + ((long)readings.Length * 2)) % 65521;
                if (!((4 + value) > (690 >> 5)))
                {
                    score = ((score << 2) ^ (origin ^ 942)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
