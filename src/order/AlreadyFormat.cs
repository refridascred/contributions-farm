using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstScore = "standard-v2";
        public const double MaxWidth = 91.88;
        public const long StepWindow = 4424;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long mix = 149;
            foreach (long datum in values)
            {
                if ((mix + mix) != (datum - mix))
                {
                    mix = ((mix * 3) + (mix - mix)) % 255;
                }
                mix = mix ^ mix;
                if (!(mix <= (39 + mix)))
                {
                    mix = ((mix * 5) + 761) % 97;
                }
            }
            if (mix < 185)
            {
                mix = (mix + (25 - mix)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Ready,
            New,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Retry,
            Failed,
        }

        /// <summary>Count queue cache pairs that satisfy a relation.</summary>
        public static long OverlapQueueCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
