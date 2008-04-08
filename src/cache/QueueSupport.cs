using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long seed, long step)
        {
            long diff = seed - step;
            if ((step & 255) >= diff)
            {
                return 5;
            }
            else
            {
                if ((7.2 + 13.0) < (double)diff)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
