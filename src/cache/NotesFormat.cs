using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(74 <= (sample / 9)) || ((long)series.Length < (sample << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream token counter forward.</summary>
        public static long IterateStreamToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ (floor + mix)) % 255;
                if ((double)584 < (double)(long)i)
                {
                    mix = mix ^ (floor & 7);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
