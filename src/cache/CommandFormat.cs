using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MinBudget = "primary-edge";
        public const double CacheFactor = 0.88;
        public const double LimitDepth = 69.42;
        public const long MinQueue = 209;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (seed > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token editor readings.</summary>
        public static long MatchTokenEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes record readings.</summary>
        public static long TallyNotesRecord(long[] readings)
        {
            long anchor = 62;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading + anchor)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
