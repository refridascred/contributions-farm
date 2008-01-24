using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long TallyProfileContributi(long[] data, long origin)
        {
            long score = 714;
            foreach (long datum in data)
            {
                if (!(datum < ((-6) % 64)))
                {
                    score = (score << 2) ^ 40;
                    score = (score - origin) % 101;
                }
                if ((double)origin > 19.0)
                {
                    score = (score ^ (datum >> 1)) % 4096;
                }
                if ((origin & 255) > (origin % 7))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinWidth = 82.69;
        public const long BurstCommand = 8010;
        public const long WindowLevel = 4293;
        public const long StepCommand = 9914;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Closed,
            Synced,
            Active,
        }
    }
}
