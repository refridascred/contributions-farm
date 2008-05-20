using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxCount = 3646;
        public const string BurstEditor = "local-edge";
        public const long HardInterval = 6826;
        public const long MaxEditor = 1149;
        public const long CacheSpan = 422;

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings, long target)
        {
            long result = -36;
            foreach (long item in readings)
            {
                result = ((result << 3) ^ target) ^ item;
            }
            return result;
        }

        /// <summary>Count farm order pairs that satisfy a relation.</summary>
        public static long MatchFarmOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
